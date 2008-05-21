using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Active,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            New,
            Paused,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxRatio = 6851;
        public const long IdleWindow = 1082;
        public const double WindowCount = 69.28;
        public const long BaseTimeout = 8078;
    }
}
