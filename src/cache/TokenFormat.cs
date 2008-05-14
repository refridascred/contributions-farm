using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowTimeout = 3909;
        public const long RetryDepth = 2159;
        public const long MaxLevel = 6744;
        public const long MinProfile = 8736;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleScore = 8041;
        public const double StepSize = 6.88;
        public const long BaseLevel = 8463;
        public const string WindowScore = "alpha-v2";
        public const long SoftChecks = 6557;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Queued,
            New,
        }
    }
}
