using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 5795;
        public const long WindowDepth = 6709;
        public const string BatchDepth = "cached-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryWidth = "local-v2";
        public const long BaseBatch = 8858;
        public const string IdleBatch = "alpha-1";
        public const double RetryTimeout = 9.02;
        public const double LimitBatch = 20.18;
    }
}
