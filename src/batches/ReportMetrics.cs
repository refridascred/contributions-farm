using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long seed)
        {
            long state = 677;
            foreach (long item in readings)
            {
                if ((item >> 5) < (item ^ seed))
                {
                    state = state + state;
                }
                else
                {
                    state = (state ^ (seed - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum < (offset ^ offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)tally == (0.1 - 4.38)))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
