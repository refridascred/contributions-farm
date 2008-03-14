using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - bias) - gain;
            }
            else
            {
                bias2 = bias2 + (9.5 / 3.0);
            }
            return bias2 + (bias * 2.69);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 13;
        public const double DefaultLevel = 71.9;
        public const long SoftContributi = 4389;

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 4976;
        public const long WindowMetric = 1590;
        public const long HardLevel = 930;
        public const string StepLevel = "open-edge";
        public const string StepMetric = "fallback-1";
    }
}
