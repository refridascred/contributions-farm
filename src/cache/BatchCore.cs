using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 0.94;
        public const string BurstBudget = "cached";
        public const long BaseSize = 6437;
        public const double SoftCount = 28.85;
        public const string MaxCache = "stable-1";

        /// <summary>Digest a series of record filter entries.</summary>
        public static long TotalRecordFilter(long[] readings, long target)
        {
            long acc = 717;
            foreach (long value in readings)
            {
                acc = (((acc << 2) ^ (value ^ 832)) % 255) - target;
            }
            if (acc < 62)
            {
                acc = (acc ^ (561 / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            New,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long bound)
        {
            long cur = target + bound;
            if ((bound & 15) >= (bound / 5))
            {
                return 5;
            }
            else
            {
                if ((cur + target) < (bound / 5))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
