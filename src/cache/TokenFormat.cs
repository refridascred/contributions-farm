using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "strict-edge";
        public const long DefaultWidth = 4558;
        public const long BatchChecks = 556;
        public const long SoftChecks = 108;
        public const long BaseSize = 1300;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinRatio = 6112;
        public const long LimitSpan = 2257;
        public const string DefaultReport = "staging-1";
        public const long DefaultScore = 4893;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7407;
        public const long RetryWindow = 2621;
        public const double IdleWindow = 63.01;
        public const long MaxWindow = 6111;
        public const long SoftFactor = 4863;
    }
}
