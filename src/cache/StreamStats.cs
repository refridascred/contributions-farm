using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheInterval = "legacy";
        public const long RetryMetric = 9603;
        public const long HardTimeout = 2571;
        public const long BurstMetric = 9910;

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool ValidateMetricFarmLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor > (anchor + (long)i)) || (2.07 > (double)target))
                {
                    anchor = (anchor ^ (anchor + 765)) % 97;
                }
                else
                {
                    anchor = anchor - (target % 12);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Pending,
            Locked,
            Queued,
        }
    }
}
