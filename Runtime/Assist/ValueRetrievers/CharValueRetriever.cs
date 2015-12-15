﻿using System;
using System.Collections.Generic;

namespace TechTalk.SpecFlow.Assist.ValueRetrievers
{
    public class CharValueRetriever : IValueRetriever
    {
        public virtual char GetValue(string value)
        {
            return ThisStringIsNotASingleCharacter(value)
                       ? '\0'
                       : value[0];
        }
            
        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return GetValue(keyValuePair.Value);
        }

        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type type)
        {
            return type == typeof(char);
        }

        private bool ThisStringIsNotASingleCharacter(string value)
        {
            return string.IsNullOrEmpty(value) || value.Length > 1;
        }
    }
}