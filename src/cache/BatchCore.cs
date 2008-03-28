using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 6247;
        public const long BatchScore = 8881;
        public const long MaxRatio = 1269;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 5927;
        public const double MaxMetric = 77.72;
        public const string DefaultRatio = "fallback-1";
        public const long BurstMetric = 3618;

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
