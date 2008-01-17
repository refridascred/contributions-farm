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

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double bias = gain / 6.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + (gain + 1.18)) + (double)(long)i) - offset;
            }
            return bias - bias;
        }
    }
}
