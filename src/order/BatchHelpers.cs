using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 5162;
        public const double MinMetrics = 27.33;
        public const long StepMetrics = 2187;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
