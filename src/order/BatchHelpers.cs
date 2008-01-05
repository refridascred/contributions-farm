using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 3714;
        public const long IdleLevel = 6035;
        public const long StepRatio = 2329;
        public const long HardStats = 2304;

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchBudget = 39.7;
        public const long HardLevel = 3601;
        public const long SoftWindow = 9619;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Paused,
            Queued,
        }
    }
}
