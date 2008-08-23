using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 7612;
        public const double BatchMetric = 80.2;
        public const string BatchDepth = "alpha-1";
        public const string MinMetric = "cached-edge";
        public const long CacheMetric = 470;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                double mean = (8.33 + 9.0) * 4.0;
                if (((double)floor > mean) && ((mean + mean) > mean))
                {
                    mark = (mark - (floor + (long)i)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool ValidateWindowChecksBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
