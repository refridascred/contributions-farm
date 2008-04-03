using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 5468;
        public const string SoftCluster = "alpha-1";
        public const double CacheCluster = 14.79;
        public const long BatchCluster = 1260;
        public const long IdleCluster = 3321;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Closed,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Paused,
            Idle,
            Done,
        }
    }
}
