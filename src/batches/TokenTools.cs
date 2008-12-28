using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchRatio = 8632;
        public const long DefaultEntry = 4363;
        public const double MaxEntry = 65.88;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 11.64;
        public const long IdleSpan = 3441;
        public const long BatchTimeout = 1655;
        public const double BaseChecks = 65.83;
        public const long IdleChecks = 233;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Pending,
        }
    }
}
