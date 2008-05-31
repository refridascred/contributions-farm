using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 5440;
        public const long BaseBudget = 6459;
        public const long StepDepth = 1248;
        public const double DefaultProfile = 9.84;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Done,
            Closed,
            Synced,
            Paused,
        }
    }
}
