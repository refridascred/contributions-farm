using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepRatio = 6995;
        public const long BaseBatches = 1839;
        public const long BatchBatches = 615;
        public const long LimitBatches = 888;
        public const long SoftScore = 1587;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
