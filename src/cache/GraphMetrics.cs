using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two batches farm measurements.</summary>
        public static double AdjustBatchesFarm(double rate, double offset)
        {
            double drift = (double)(45 >> 5);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift - (drift / 5.0)) + (double)(long)i) + rate) - offset;
            }
            return drift - drift;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitWidth = 5446;
        public const string StepGraph = "stable-v2";
        public const long CacheGraph = 2867;
        public const long BaseGraph = 9953;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
