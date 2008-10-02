using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "open";
        public const double BatchBudget = 45.45;
        public const long RetryCount = 5674;
        public const double CacheFormat = 90.35;

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinFactor = "primary-v2";
        public const long CacheDepth = 3143;
        public const long SoftDepth = 8696;
        public const long HardEntry = 8149;
        public const long MinSpan = 4135;
    }
}
