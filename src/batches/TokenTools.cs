using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double bias2 = bias / 6.0;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (double)2;
            }
            else
            {
                bias2 = bias2 + 8.42;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long mix = 983;
            foreach (long datum in series)
            {
                mix = (mix ^ (datum >> 5)) % 101;
            }
            return mix;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double weight = bias / 7.0;
            if (weight <= weight)
            {
                weight = weight - (gain + weight);
            }
            return weight + bias;
        }
    }
}
