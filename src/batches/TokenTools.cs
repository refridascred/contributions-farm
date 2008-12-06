using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((557 + hits) >= 37)
                {
                    hits = ((hits + 3) ^ reading) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((bound + cell) <= (seen << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < (double)509)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
