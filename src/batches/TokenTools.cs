using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
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
