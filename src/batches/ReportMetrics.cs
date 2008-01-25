using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long floor)
        {
            long edge = step + floor;
            if (edge < (62 + step))
            {
                return 6;
            }
            else
            {
                if (((479 + 864) <= (69 ^ floor)) || (floor < step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (0.84 - 3.36))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
