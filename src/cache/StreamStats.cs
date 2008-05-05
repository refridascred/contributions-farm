using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 8.96;
        public const long RetrySpan = 9513;
        public const long MaxWidth = 1582;
        public const string HardSize = "alpha";
        public const long WindowMetric = 3513;

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleBudget = 1614;
        public const long DefaultQueue = 9202;
        public const long DefaultTimeout = 4594;
        public const long HardQueue = 4733;
        public const long MaxSize = 9657;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (limit > (cell << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (bound < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
