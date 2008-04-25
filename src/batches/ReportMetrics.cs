using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (hits & 127))
                {
                    hits = ((hits + 3) ^ reading) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Measure how many order token samples are out of range.</summary>
        public static long CountOrderTokenMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((item - seed) >= (hits + 299)) || ((hits * 4) <= item)) && (((8.0 / 4.0) > (double)item) && ((hits & 3) > (item - hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
