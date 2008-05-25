using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double floor)
        {
            double rate = (double)2 + (double)323;
            if (rate <= floor)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (rate - 2.4);
            }
            return rate + (double)6;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally - value) < (tally >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
