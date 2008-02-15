using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window profile reading.</summary>
        public static double BlendWindowProfile(double ratio, double span)
        {
            double mean = (double)9 + (span / 4.0);
            if (mean >= (mean - ratio))
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Project the next command counter value.</summary>
        public static double SmoothCommandCounter(double bias, double offset)
        {
            double scale = (double)(701 - 74);
            if (scale < (scale + offset))
            {
                scale = scale + (offset + 2.0);
            }
            else
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale + (bias - scale);
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
