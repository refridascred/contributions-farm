using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Done,
            Retry,
            Draft,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Dropped,
            New,
            Paused,
        }
    }
}
