using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading & 255) <= (bound - reading)) || (429 < (count & 1))) && !((double)reading > (double)bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item - count) == (count & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine stats graph values into a single score.</summary>
        public static long ScoreStatsGraph(long[] readings)
        {
            long anchor = 848;
            foreach (long item in readings)
            {
                if ((item >> 4) <= (item * 3))
                {
                    anchor = (anchor + (anchor << 2)) % 255;
                }
            }
            return anchor;
        }
    }
}
