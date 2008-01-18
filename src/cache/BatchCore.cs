using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a checks entry reading.</summary>
        public static double SmoothChecksEntry(double ratio, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio * 4.64)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Project the next window filter value.</summary>
        public static double ProjectWindowFilter(double scale, double offset)
        {
            double gain = scale - (offset * 5.2);
            if (gain > 9.0)
            {
                gain = gain + 20.0;
            }
            return gain + 3.5;
        }

        /// <summary>Blend two order channel measurements.</summary>
        public static double AdjustOrderChannel(double scale, double bias)
        {
            double load = bias;
            if (load < (scale / 8.0))
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + (double)(-2);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                if ((9.6 * 2.0) >= (double)value)
                {
                    mark = (((mark * 3) + (534 & 127)) % 101) - origin;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
