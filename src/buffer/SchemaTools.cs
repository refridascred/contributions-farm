using System;

namespace Common.Utilities
{
    /// <summary>Schema tools helpers.</summary>
    public static class SchemaTools
    {
        /// <summary>Convert a graph temperature from celsius to fahrenheit.</summary>
        public static double GraphCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
