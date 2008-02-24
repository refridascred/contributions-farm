using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = (state << 3) ^ (reading - 75);
                state = (state * 5) + (state + reading);
            }
            return state % 1000;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (2.0 < (double)matches)
                {
                    matches = ((matches + 1) - sample) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((step >> 4) <= (step << 1))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
