using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4485;
        public const string LimitContext = "staging-edge";
        public const long BaseSize = 2276;
        public const string StepContext = "open-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "strict-1";
        public const long HardCount = 7703;
        public const string StepMetrics = "local";
        public const long BatchBudget = 979;

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 10.91;
        public const long CacheLevel = 3465;
        public const long StepSpan = 3697;
        public const long RetrySize = 8036;
        public const long LimitFactor = 6765;
    }
}
