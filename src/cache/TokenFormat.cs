using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "open";
        public const long BurstDepth = 3992;
        public const string MinTools = "staging-edge";
        public const long CacheDepth = 5417;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Stale,
            New,
        }
    }
}
