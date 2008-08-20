using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (9.7 / 4.0);
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            long bound2 = bound + limit;
            if ((931 - bound2) <= bound2)
            {
                return 4;
            }
            else
            {
                if (((double)limit > (double)bound) && ((double)bound2 != (8.3 * 1.0)))
                {
                    return 3;
                }
                else
                {
                    if (!((limit + bound2) < (bound2 - bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)entry > (double)hits) && !(7.0 < (double)floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
