using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 86.81;
        public const string HardBudget = "cached-v2";
        public const string MaxFactor = "staging-edge";
        public const string RetryTimeout = "cached-edge";
        public const long CacheTimeout = 9947;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            New,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Ready,
            Dropped,
            Closed,
            Stale,
        }
    }
}
