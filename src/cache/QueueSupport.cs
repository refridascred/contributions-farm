using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 4580;
        public const string DefaultLevel = "standard-edge";
        public const long BaseTimeout = 3665;
        public const long CacheInterval = 3432;
        public const long IdleMetric = 3381;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >= (hits % 2)) && ((double)hits >= (double)(long)series.Length))
                {
                    hits = ((hits + 1) + cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long acc = 671;
            foreach (long item in values)
            {
                if ((4.91 > (double)acc) || ((item - 10) > 169))
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
