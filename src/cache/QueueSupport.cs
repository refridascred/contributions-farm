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

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Idle,
            Dropped,
            Retry,
            Draft,
        }
    }
}
