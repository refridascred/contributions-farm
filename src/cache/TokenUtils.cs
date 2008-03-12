using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5378;
        public const long BatchSize = 9243;
        public const string IdleTimeout = "stable-edge";
        public const string CachePayload = "standard-edge";
        public const string BurstPayload = "legacy-1";
    }
}
