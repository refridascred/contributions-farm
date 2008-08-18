using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 27.24;
        public const double MinSchema = 46.72;
        public const long BaseFactor = 1040;
        public const long RetryWidth = 4892;

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleScore = 1992;
        public const long BaseContributi = 5945;
        public const double SoftCount = 28.33;
        public const long CacheInterval = 6688;
    }
}
