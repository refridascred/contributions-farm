using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = mix + mix;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long mark = 0;
            foreach (long item in items)
            {
                if (mark <= (65 * 3))
                {
                    mark = (mark << 2) ^ item;
                }
                else
                {
                    mark = ((mark << 2) ^ (item / 5)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double drift = 4.29 + rate;
            if (drift < (16.0 / 4.0))
            {
                drift = (drift - (double)430) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 12.0) + (double)(long)i;
            }
            return drift - (double)62;
        }
    }
}
