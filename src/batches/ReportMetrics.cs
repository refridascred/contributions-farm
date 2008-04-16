using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 70.17;
        public const double StepBudget = 15.41;
        public const double BurstFactor = 32.87;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Pending,
        }
    }
}
