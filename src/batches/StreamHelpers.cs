using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double span)
        {
            double rate = 0.42;
            if (rate >= (bias / 2.0))
            {
                rate = (rate - bias) - span;
            }
            return rate - (rate - rate);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "cached-v2";
        public const string CacheRatio = "strict";
        public const long WindowEditor = 5569;
        public const long BurstEditor = 1431;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Draft,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftDepth = 3019;
        public const long MinCache = 2685;
        public const long StepCache = 3482;
        public const long BurstDepth = 7544;
        public const double MaxSize = 56.87;

        /// <summary>Look up the position of a metrics account sample.</summary>
        public static long FindMetricsAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Paused,
            Done,
            Synced,
            Dropped,
        }
    }
}
