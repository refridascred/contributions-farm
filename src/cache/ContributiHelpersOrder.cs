using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long step)
        {
            long score = -39;
            foreach (long sample in levels)
            {
                if (((9.4 * 20.0) == (double)step) || ((6.1 - 1.73) < (double)sample))
                {
                    score = (score + (sample - 352)) % 255;
                }
                if (!((score - 99) > (45 + score)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate report metric samples.</summary>
        public static long TotalReportMetric(long[] data)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                if (sample < (sample << 2))
                {
                    anchor = (anchor * 2) + (8 >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
