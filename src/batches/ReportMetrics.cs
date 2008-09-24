using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Ready,
            Done,
            Closed,
        }
    }
}
