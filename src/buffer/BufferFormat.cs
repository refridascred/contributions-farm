using System;

namespace Common.Utilities
{
    /// <summary>Buffer format helpers.</summary>
    public static class BufferFormat
    {
        /// <summary>Convert a profile temperature from celsius to fahrenheit.</summary>
        public static double ProfileCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
