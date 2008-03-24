using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Stale,
            Failed,
        }

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
