using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two farm editor measurements.</summary>
        public static double SmoothFarmEditor(double scale, double span)
        {
            double mean = scale * 2.7;
            if (mean >= (5.1 / 5.0))
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 9.0)) - (double)(long)i;
            }
            return mean - (span / 5.0);
        }

        /// <summary>Locate a channel editor reading by value.</summary>
        public static long LookupChannelEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
