using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Idle,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Failed,
        }
    }
}
