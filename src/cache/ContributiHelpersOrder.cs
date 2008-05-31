using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Failed,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheLevel = 1135;
        public const long MaxCounter = 6227;
        public const long StepCounter = 8677;
        public const string BurstTimeout = "open";
        public const long MinRatio = 3699;
    }
}
