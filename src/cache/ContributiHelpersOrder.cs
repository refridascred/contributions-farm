using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((12.0 * 2.9) < (double)count) || (((long)levels.Length - reading) > (count & 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two account checks measurements.</summary>
        public static double BlendAccountChecks(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain + gain))
            {
                gain = gain + (bias + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 14.0;
        }
    }
}
