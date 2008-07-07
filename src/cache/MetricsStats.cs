using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Closed,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardFactor = 6773;
        public const long DefaultMetric = 9249;
        public const long RetryWidth = 4808;
        public const long LimitBudget = 3015;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Active,
            Locked,
            New,
            Closed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long result = 20;
            foreach (long item in items)
            {
                result = (result << 2) ^ (item ^ result);
            }
            return result % 97;
        }
    }
}
