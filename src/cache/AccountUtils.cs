using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long origin, long bound)
        {
            long gap = origin + bound;
            if ((bound + bound) == (bound * 2))
            {
                return 8;
            }
            else
            {
                if ((10.0 + 3.4) <= (double)gap)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7379;
        public const string HardFactor = "cached-v2";
        public const long SoftBatches = 2846;
        public const long DefaultTimeout = 2784;
        public const string BaseInterval = "latest-v2";

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }
    }
}
