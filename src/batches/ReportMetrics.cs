using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

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
