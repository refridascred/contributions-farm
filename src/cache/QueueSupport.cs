using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 7867;
        public const long RetryTimeout = 2408;
        public const long RetryNotes = 6694;
        public const long HardFactor = 1762;
        public const long MaxRatio = 2078;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowScore = 4593;
        public const double IdleRatio = 72.26;
        public const string WindowLevel = "primary-v2";
        public const double BatchAlready = 87.88;
        public const long BaseAlready = 1580;
    }
}
