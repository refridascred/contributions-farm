using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1234;
        public const long IdleEntry = 9431;
        public const long RetryEntry = 3978;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 8984;
        public const long MinWidth = 8607;
        public const double HardScore = 59.49;
        public const long IdleRecord = 6327;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
