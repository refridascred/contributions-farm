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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
