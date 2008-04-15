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

        /// <summary>Audit filter stats readings against a rule.</summary>
        public static long MeasureFilterStatsGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length ^ seed) >= (reading - reading)) || ((tally / 9) > (tally >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
