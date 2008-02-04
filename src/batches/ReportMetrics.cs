using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((16.0 + 3.0) > (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long CountQueueWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)item <= (6.0 / 4.0)) && ((tally / 6) <= item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long state = 8;
            foreach (long reading in series)
            {
                state = ((state ^ (reading >> 4)) % 65521) + floor;
            }
            return state;
        }
    }
}
