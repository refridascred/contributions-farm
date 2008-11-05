using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 802;
        public const long StepCount = 4655;
        public const double MaxOrder = 29.17;
        public const long BurstOrder = 4679;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinLevel = 7311;
        public const double SoftChecks = 84.83;
        public const long MinSpan = 3045;
        public const string IdleBudget = "alpha-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 37.45;
        public const long HardWidth = 5291;
        public const long DefaultQueue = 9593;
        public const long CacheDepth = 9237;
        public const long MinCount = 6853;

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseWidth = "stable";
        public const long RetryTimeout = 7555;
        public const long StepAlready = 2935;
        public const long CacheAlready = 9521;
        public const long BatchAlready = 7399;
    }
}
