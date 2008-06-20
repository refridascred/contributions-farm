using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            New,
            Active,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 23.52;
        public const string WindowAccount = "primary-edge";
        public const long LimitAccount = 2531;

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 93.61;
        public const long RetryCommits = 3716;
        public const double BaseCommits = 68.36;
        public const long MinTimeout = 4298;
    }
}
