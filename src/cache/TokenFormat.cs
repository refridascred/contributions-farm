using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Active,
            Done,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 3993;
        public const double BaseDepth = 94.82;
        public const long SoftScore = 111;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 685;
        public const long SoftTimeout = 1509;
        public const string MaxTimeout = "primary-v2";
        public const double LimitBuffer = 64.17;
    }
}
