using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 1425;
        public const long BatchLevel = 1174;
        public const long MaxFarm = 5164;
        public const double IdleFarm = 24.88;

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxLevel = "standard";
        public const double IdleRatio = 41.47;
        public const string StepBudget = "open-edge";
        public const string IdleWidth = "cached-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 3343;
        public const long RetryMetric = 8492;
        public const string HardCount = "strict-v2";
        public const long MaxMetric = 592;
        public const long WindowCount = 5098;
    }
}
