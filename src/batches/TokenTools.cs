using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryCount = 11.54;
        public const long StepRecord = 7828;
        public const long WindowInterval = 1660;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Idle,
            Ready,
            Stale,
            Closed,
        }
    }
}
