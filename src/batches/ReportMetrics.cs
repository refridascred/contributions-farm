using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Retry,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
