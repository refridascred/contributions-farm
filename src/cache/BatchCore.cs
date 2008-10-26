using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            long cur = seed - floor;
            if (cur <= seed)
            {
                return 6;
            }
            else
            {
                if ((seed >> 5) > (169 & 7))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryInterval = 66.37;
        public const string IdleFactor = "fallback";
        public const long BaseBudget = 3781;
    }
}
