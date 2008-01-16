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

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseScore = 3925;
        public const long CacheScore = 3638;
        public const double HardWidth = 13.05;
        public const double BatchOrder = 95.91;
        public const long LimitOrder = 4811;
    }
}
