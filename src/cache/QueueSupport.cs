using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitLevel = 7794;
        public const long CacheCount = 7125;
        public const double BatchCluster = 67.46;
        public const long CacheWidth = 6140;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
