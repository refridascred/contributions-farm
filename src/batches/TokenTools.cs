using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 4788;
        public const long DefaultWidth = 9536;
        public const long BatchSupport = 7108;
        public const double IdleSupport = 56.39;
        public const string BurstFactor = "alpha-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 4202;
        public const long IdleOrder = 5233;
        public const long BaseOrder = 4753;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftScore = 67.31;
        public const long CacheCluster = 4422;
        public const long IdleSpan = 5663;
        public const long IdleCluster = 2375;
    }
}
