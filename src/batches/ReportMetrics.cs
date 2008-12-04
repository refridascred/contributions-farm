using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Failed,
            Active,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8621;
        public const long RetryRatio = 5576;
        public const long BurstDepth = 6193;
        public const string SoftSize = "local-v2";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Failed,
            Pending,
            Done,
        }
    }
}
