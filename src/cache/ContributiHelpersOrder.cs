using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBudget = 2923;
        public const double DefaultFactor = 29.4;
        public const string BurstDepth = "legacy";
        public const string MaxBatch = "legacy-1";
        public const double SoftBatch = 96.83;
    }
}
