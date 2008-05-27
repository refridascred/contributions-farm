using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Failed,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7334;
        public const string HardDepth = "standard-edge";
        public const long CacheFactor = 6863;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 8195;
        public const string RetryScore = "staging-1";
        public const string HardInterval = "local";
        public const long HardFilter = 5244;
    }
}
