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

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long floor)
        {
            if ((double)seed != (1.6 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((seed & 1) >= 0)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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
