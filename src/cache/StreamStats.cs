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

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 63.59;
        public const string MinBudget = "primary";
        public const double BurstFactor = 59.47;
        public const string BaseLevel = "stable";

        /// <summary>Validate record stats readings against a bound.</summary>
        public static bool CheckRecordStatsRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
