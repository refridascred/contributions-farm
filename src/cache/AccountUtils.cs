using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheInterval = 1149;
        public const long BurstSize = 846;
        public const double LimitDepth = 56.26;
        public const long BaseAlready = 4305;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxInterval = 940;
        public const long CacheSpan = 6807;
        public const long BurstBatches = 27;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (score << 1)) + item;
            }
            if (score < 9)
            {
                score = (score << 2) ^ (score + score);
            }
            return score % 1000;
        }
    }
}
