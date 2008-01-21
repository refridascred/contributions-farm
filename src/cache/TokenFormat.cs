using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 16.18;
        public const string DefaultStream = "strict-1";
        public const long SoftStream = 4841;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2436;
        public const long LimitToken = 5400;
        public const long IdleCount = 9914;
        public const long RetryDepth = 985;
    }
}
