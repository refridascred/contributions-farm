using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Locked,
            Pending,
            Ready,
            Idle,
        }
    }
}
