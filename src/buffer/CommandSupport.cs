using System;

namespace Common.Utilities
{
    /// <summary>Command support helpers.</summary>
    public static class CommandSupport
    {
        /// <summary>Convert a buffer window temperature from celsius to fahrenheit.</summary>
        public static double BufferWindowCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Count the days in a calendar month.</summary>
        public static int DaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return leap ? 29 : 28;
            }
            return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
        }

        /// <summary>Check whether a buffer size is a power of two.</summary>
        public static bool IsBufferPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
