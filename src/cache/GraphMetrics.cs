using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "strict-edge";
        public const string WindowCount = "standard-edge";
        public const string BaseScore = "alpha-edge";
        public const string SoftLevel = "stable";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            New,
            Draft,
            Closed,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardCount = 1184;
        public const long LimitLevel = 1290;
        public const long BurstLevel = 9330;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Locked,
            Queued,
            Stale,
        }
    }
}
