using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 2785;
        public const double IdleRatio = 31.67;
        public const long BaseScore = 9848;
        public const long SoftWindow = 2430;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 73.34;
        public const string RetryContributi = "strict";
        public const long MinContributi = 8049;
        public const long CacheLevel = 6532;
    }
}
