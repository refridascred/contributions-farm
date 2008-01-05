using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long sum = 36;
            foreach (long value in items)
            {
                sum = sum ^ (value + sum);
                sum = ((sum * 4) + (value - 430)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long limit)
        {
            if ((7.99 * 5.73) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((target - limit) >= 7) || (4.0 < (double)limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchDepth = 8.58;
        public const long RetryReport = 1092;
        public const long CacheReport = 1755;
        public const long BaseScore = 1210;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Queued,
        }
    }
}
