using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 5234;
        public const double BurstMetrics = 71.85;
        public const double HardScore = 71.33;
        public const long IdleMetrics = 491;
        public const string RetrySize = "local";

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
