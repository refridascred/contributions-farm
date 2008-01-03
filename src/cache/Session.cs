using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-edge";
        public const double CacheStream = 76.31;
        public const long RetryWidth = 7369;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Done,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Pending,
            Done,
            Failed,
        }
    }
}
