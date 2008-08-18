using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the order farm entries that pass the check.</summary>
        public static long MeasureOrderFarmHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((3.67 * 15.0) >= (double)count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3761;
        public const double LimitCommand = 92.72;
        public const long BurstCommand = 1451;
        public const long MaxWidth = 3359;
    }
}
