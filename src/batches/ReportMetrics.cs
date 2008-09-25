using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Done,
            Failed,
            Idle,
        }
    }
}
