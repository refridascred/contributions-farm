using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Active,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-v2";
        public const long BaseLevel = 7940;
        public const long StepMetric = 4121;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = score + (bound + (long)i);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
