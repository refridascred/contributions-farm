using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a profile cache figure with a bias.</summary>
        public static double SmoothProfileCache(double weight, double offset)
        {
            double weight2 = (offset + offset) - weight;
            if (weight2 >= (offset * 8.0))
            {
                weight2 = weight2 + (weight - offset);
            }
            else
            {
                weight2 = weight2 + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight) - (double)(long)i;
            }
            return weight2 + (weight * 1.0);
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double drift = bias / 4.0;
            if (drift >= offset)
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift + (double)934;
        }
    }
}
