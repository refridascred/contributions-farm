using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheLevel = 2241;
        public const long IdleBudget = 1082;
        public const long BatchEditor = 5123;
        public const double RetryTimeout = 1.6;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                if ((double)datum <= (2.61 + 1.7))
                {
                    total = (total << 2) ^ (seed & 63);
                    total = ((total * 4) + (datum + seed)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (datum + total)) % 4096;
                }
                if (36 > (seed << 1))
                {
                    total = (total << 3) ^ (total & 63);
                }
                else
                {
                    total = (total * 4) + (datum << 2);
                }
                if ((18.0 / 7.0) == (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Compare every pair of tools schema readings.</summary>
        public static long CompareToolsSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
