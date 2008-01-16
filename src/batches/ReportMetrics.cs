using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Paused,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 9145;
        public const string BaseScore = "staging-1";
        public const double SoftDepth = 50.72;
        public const long MinTimeout = 1147;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6288;
        public const string BaseTimeout = "strict-edge";
        public const string BurstBudget = "staging";
        public const long BatchBuffer = 4141;
    }
}
