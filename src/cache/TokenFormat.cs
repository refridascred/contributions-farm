using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            New,
            Stale,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 9442;
        public const long RetrySupport = 3759;
        public const long WindowWidth = 3900;
        public const long StepSupport = 6195;

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 50.65;
        public const double BaseWidth = 93.54;
        public const long BurstSpan = 9858;
        public const long StepSpan = 7479;
        public const long MinFactor = 2596;
    }
}
