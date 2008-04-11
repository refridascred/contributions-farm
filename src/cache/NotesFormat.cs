using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 8412;
        public const string BurstTimeout = "local";
        public const long RetryCluster = 6144;
        public const long BurstSize = 5140;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 8805;
        public const long IdleSize = 9238;
        public const string DefaultContext = "local-1";
        public const long CacheInterval = 9128;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Active,
            Closed,
            New,
        }
    }
}
