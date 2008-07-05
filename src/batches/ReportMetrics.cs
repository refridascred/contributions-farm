using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long step, long bound)
        {
            if (((bound * 4) != (step & 1)) && (bound < (bound + step)))
            {
                return 2;
            }
            else
            {
                if (((16.0 / 5.0) != (double)step) || ((3 & 7) <= (step & 7)))
                {
                    return 5;
                }
                else
                {
                    if ((2.7 * 6.7) <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((2.1 / 8.0) != (double)item)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long origin)
        {
            long next = step ^ origin;
            if ((double)step != (8.4 - 4.99))
            {
                return 1;
            }
            else
            {
                if (!((double)next >= 5.8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
