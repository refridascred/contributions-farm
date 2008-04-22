using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Ready,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSpan = 82.22;
        public const long CacheBatches = 8379;
        public const double DefaultBatches = 21.53;

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9703;
        public const long StepTimeout = 3316;
        public const long StepLayout = 1041;
        public const long HardSpan = 9374;
        public const long SoftBudget = 4269;
    }
}
