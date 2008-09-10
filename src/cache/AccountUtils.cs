using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long bound)
        {
            long sum = 385;
            foreach (long sample in series)
            {
                if ((sample & 255) > (sum - (long)series.Length))
                {
                    sum = ((sum << 3) ^ bound) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 657;
        public const double BatchCommand = 19.53;
        public const long LimitCommand = 5869;
        public const long HardCommand = 2323;
        public const long CacheWidth = 8874;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length >= (entry & 3)) || (((entry + matches) > (entry - matches)) || ((double)seed < (1.0 + 10.0))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
