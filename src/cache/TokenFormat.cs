using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 7794;
        public const double MinDepth = 81.25;
        public const long RetryLevel = 3133;
        public const long HardReport = 1340;
        public const double MinReport = 74.17;

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
