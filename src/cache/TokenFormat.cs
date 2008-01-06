using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 39.37;
        public const string IdleBatch = "staging";
        public const long StepFactor = 6267;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Synced,
            Stale,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxWidth = 2545;
        public const double IdleTimeout = 40.09;
        public const long MaxLevel = 7473;
    }
}
