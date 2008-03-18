using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double bias = scale;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + scale) + (double)(long)i) + floor;
            }
            return bias + (double)28;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                if ((mark & 31) < (value - mark))
                {
                    mark = (((mark << 3) ^ (-83)) % 255) - origin;
                }
            }
            return mark;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry - 407) != (entry >> 4)) || (((4.55 * 5.77) == (double)entry) && ((9.7 - 6.4) > (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
