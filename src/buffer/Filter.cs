using System;

namespace Common.Utilities
{
    /// <summary>Filter helpers.</summary>
    public static class Filter
    {
        /// <summary>Average a list of booking samples.</summary>
        public static double AverageBooking(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Check whether a channel size is a power of two.</summary>
        public static bool IsChannelPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Average a list of route samples.</summary>
        public static double AverageRoute(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }
    }
}
