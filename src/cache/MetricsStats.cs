using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long limit)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                if ((double)limit <= (19.0 / 6.0))
                {
                    acc = ((acc - (acc % 8)) % 101) - datum;
                }
            }
            return acc;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepInterval = 5655;
        public const long DefaultInterval = 2595;
        public const long BaseRoute = 6682;
        public const string StepRoute = "fallback-1";
        public const long BatchInterval = 3662;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
