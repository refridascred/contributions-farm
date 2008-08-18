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

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 94.29;
        public const long HardRoute = 3953;
        public const string StepRoute = "cached-1";
    }
}
