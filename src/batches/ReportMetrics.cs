using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the route format entries that pass the check.</summary>
        public static long MeasureRouteFormatMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)38)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] levels)
        {
            long score = 63;
            foreach (long item in levels)
            {
                if ((double)score == (5.37 * 1.65))
                {
                    score = score + (item + item);
                }
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
