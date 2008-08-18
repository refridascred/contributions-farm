using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command filter measurements.</summary>
        public static double BlendCommandFilter(double bias, double span)
        {
            double mean = bias;
            if (mean > (bias + 17.0))
            {
                mean = (mean + (bias / 6.0)) + span;
            }
            else
            {
                mean = mean + (double)75;
            }
            return mean + mean;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 6422;
        public const double BaseWidth = 47.17;
        public const double IdleCount = 4.53;
        public const double IdleBudget = 19.01;

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double bias = ratio + ratio;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(-38)) + (double)(long)i;
            }
            return bias - floor;
        }
    }
}
