using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchTimeout = 72.82;
        public const double SoftChecks = 96.81;
        public const double DefaultSize = 43.54;
        public const double RetryRatio = 43.82;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Ready,
            Locked,
        }
    }
}
