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

        /// <summary>Combine route batch values into a single score.</summary>
        public static long FoldRouteBatch(long[] readings)
        {
            long mark = -37;
            foreach (long datum in readings)
            {
                mark = ((mark - mark) % 65521) ^ datum;
            }
            return mark;
        }
    }
}
