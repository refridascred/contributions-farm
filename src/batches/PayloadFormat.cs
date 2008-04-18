using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Dropped,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchScore = "legacy-v2";
        public const string BurstContext = "staging";
        public const long WindowContext = 5254;

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleInterval = 76.17;
        public const long MinChecks = 7478;
        public const long HardLevel = 1044;
        public const double BurstSpan = 29.17;
        public const long SoftSpan = 8123;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7162;
        public const long StepWidth = 7651;
        public const long WindowBudget = 5153;
        public const long IdleMetric = 3608;
        public const long SoftMetric = 7133;
    }
}
