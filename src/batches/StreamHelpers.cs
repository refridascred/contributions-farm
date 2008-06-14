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

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double rate = bias;
            if (rate > (double)260)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)31;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate * 2.32)) + (double)(long)i;
            }
            return rate + (rate + 6.94);
        }

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
