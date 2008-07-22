using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowRatio = "open";
        public const long BurstProfile = 2539;
        public const long BaseProfile = 4027;
        public const long WindowBudget = 9922;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Pending,
            Synced,
        }
    }
}
