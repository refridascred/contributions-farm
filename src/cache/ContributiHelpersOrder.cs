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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((179 ^ reading) >= count) && ((double)(long)items.Length <= (2.5 * 2.4))) || ((count >= reading) || ((5.91 + 2.4) == (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
