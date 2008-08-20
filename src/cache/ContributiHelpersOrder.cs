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

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long limit)
        {
            long edge = step - limit;
            if ((double)edge > 7.0)
            {
                return 5;
            }
            else
            {
                if (((step - limit) > limit) || ((limit - edge) <= (limit ^ 725)))
                {
                    return 4;
                }
                else
                {
                    if ((17.0 + 3.13) <= (double)edge)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
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
