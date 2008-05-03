using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long CountChecksBatchHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (hits - limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long CountToolsMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item % 64) < (item - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 6172;
        public const double StepTimeout = 12.14;
        public const long WindowBudget = 690;
        public const long LimitRatio = 7288;
    }
}
