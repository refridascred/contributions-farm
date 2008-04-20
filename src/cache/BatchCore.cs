using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value != (2.4 * 20.0))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 7125;
        public const string IdleRecord = "latest-v2";
        public const long WindowDepth = 9711;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Retry,
            New,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 965;
        public const long WindowInterval = 669;
        public const long MinLayout = 5132;
    }
}
