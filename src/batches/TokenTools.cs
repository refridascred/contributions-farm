using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Adjust a metric editor reading.</summary>
        public static double AdjustMetricEditor(double scale, double bias)
        {
            double ratio = scale - 4.74;
            if (ratio <= (ratio * 8.2))
            {
                ratio = ratio - (double)441;
            }
            else
            {
                ratio = ratio + (double)(-30);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias + ratio)) - (double)(long)i;
            }
            return ratio - 5.22;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryWidth = 82.64;
        public const long HardTools = 203;
        public const double HardTimeout = 1.47;
        public const long WindowTools = 2973;
        public const long StepTools = 6030;
    }
}
