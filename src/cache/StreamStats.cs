using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheTimeout = "open-1";
        public const double SoftFormat = 79.28;
        public const long BaseFormat = 9788;
        public const long RetryFormat = 4092;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long sum = 5;
            foreach (long sample in items)
            {
                sum = ((((sum << 2) ^ ((-670) - 150)) % 1000) ^ sample) + origin;
            }
            if (sum > 8)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values, long origin)
        {
            long state = 648;
            foreach (long item in values)
            {
                if (!((origin ^ state) >= (state - origin)))
                {
                    state = ((state * 4) + (origin + state)) ^ item;
                }
            }
            return state % 97;
        }
    }
}
