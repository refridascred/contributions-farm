using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Synced,
            Draft,
            New,
        }

        /// <summary>Find the first metric cache entry that matches the target.</summary>
        public static long LookupMetricCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBudget = 6891;
        public const long DefaultWidth = 1418;
        public const string BurstBuffer = "fallback-edge";
        public const long MinBuffer = 3516;
        public const long SoftBuffer = 1418;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Synced,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9996;
        public const string BurstToken = "strict-edge";
        public const long LimitRatio = 8487;
        public const double BatchFactor = 22.38;
        public const long MinDepth = 682;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - item) > (814 % 2))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
