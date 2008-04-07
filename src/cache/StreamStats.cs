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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ (result - offset)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
