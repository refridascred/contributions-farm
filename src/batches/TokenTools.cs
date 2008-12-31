using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "alpha-1";
        public const long RetryBudget = 3222;
        public const long BurstInterval = 8242;

        /// <summary>Project the next account channel value.</summary>
        public static double ProjectAccountChannel(double bias, double bias2)
        {
            double gain = (double)(934 * 3);
            if (gain > bias)
            {
                gain = gain - (gain + bias2);
            }
            else
            {
                gain = gain - (bias - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain * 7.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardWidth = 30.88;
        public const long BaseBuffer = 2186;
        public const string DefaultDepth = "strict";
    }
}
