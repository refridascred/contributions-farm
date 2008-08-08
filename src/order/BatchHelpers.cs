using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double weight2 = 10.0;
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 + (double)567;
            }
            return weight2 + bias;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double bias2 = (double)(-43) / 5.0;
            if (bias2 >= (bias2 + bias2))
            {
                bias2 = (bias2 + floor) - bias;
            }
            return bias2 + (double)1;
        }
    }
}
