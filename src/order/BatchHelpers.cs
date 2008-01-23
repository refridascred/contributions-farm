using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8623;
        public const long SoftMetrics = 6415;
        public const long StepMetrics = 3280;
        public const long HardMetrics = 1791;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 174;
        public const string MaxScore = "latest-1";
        public const long LimitFormat = 6064;

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 89.65;
        public const long IdleCount = 6026;
        public const long DefaultSpan = 8107;
        public const long LimitCounter = 7691;
        public const string StepSize = "open-1";
    }
}
