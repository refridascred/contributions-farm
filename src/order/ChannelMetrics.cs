using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 7.77;
        public const double BaseQueue = 22.97;
        public const string MaxFactor = "cached-v2";

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long offset)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                anchor = ((anchor ^ item) % 4096) + offset;
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor;
        }
    }
}
