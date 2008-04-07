using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double bias2 = (double)590 * 3.9;
            if (bias2 >= 4.0)
            {
                bias2 = ((bias2 + bias2) + scale) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)233;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long mix = 454;
            foreach (long value in samples)
            {
                if ((seed << 2) >= mix)
                {
                    mix = ((mix << 3) ^ (value << 3)) % 1000;
                }
                if ((8.39 + 9.2) < (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum < ((-66) + datum)) && !(seen >= 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - scale;
            }
            return weight - (weight + weight);
        }
    }
}
