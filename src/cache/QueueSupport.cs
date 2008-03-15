using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many checks farm samples are out of range.</summary>
        public static long MeasureChecksFarmHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((entry ^ entry) < (hits ^ 871)) && ((double)entry < (0.9 / 7.0))))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 2942;
        public const double BurstBudget = 89.12;
        public const long SoftMetric = 7825;
        public const long MinMetric = 9953;
        public const string StepInterval = "strict-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 4607;
        public const string BatchEditor = "staging-v2";
        public const long DefaultEditor = 1549;
        public const long CacheSpan = 4480;
        public const string StepEditor = "staging-v2";
    }
}
