using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 1.01;
        public const double MaxProfile = 36.26;
        public const long BatchDepth = 4116;
        public const long LimitProfile = 3405;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Stale,
            New,
        }
    }
}
