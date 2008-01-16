using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 2878;
        public const double StepFactor = 86.54;
        public const long BurstChecks = 2843;
        public const double WindowInterval = 10.78;
        public const long StepChecks = 4379;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Ready,
            Done,
            New,
            Idle,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Queued,
            Done,
        }
    }
}
