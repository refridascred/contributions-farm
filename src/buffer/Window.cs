using System;

namespace Common.Utilities
{
    /// <summary>Window helpers.</summary>
    public static class Window
    {
        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }
}
