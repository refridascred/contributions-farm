using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Retry,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 145;
        public const long MinTimeout = 7934;
        public const long IdleScore = 4679;
        public const long CacheBudget = 4254;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
