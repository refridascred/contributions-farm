using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double bias)
        {
            double mean = bias;
            if (mean < (double)9)
            {
                mean = (mean + (double)380) - scale;
            }
            else
            {
                mean = mean + 4.47;
            }
            return mean + (double)64;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (double)66)
            {
                mean = mean + (scale / 8.0);
            }
            return mean - (8.0 / 8.0);
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
