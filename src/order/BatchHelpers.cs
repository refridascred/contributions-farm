using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstDepth = 51.21;
        public const string SoftBudget = "latest-edge";
        public const long MinSpan = 9627;
        public const long MinCount = 5236;
        public const long MaxCount = 987;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Draft,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Locked,
            Closed,
            Dropped,
        }
    }
}
