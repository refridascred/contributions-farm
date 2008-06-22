using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Ready,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 359;
        public const long CacheTimeout = 5745;
        public const long MinGraph = 2959;
        public const long BatchSize = 6431;
        public const long BurstGraph = 2293;
    }
}
