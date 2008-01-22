using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepTimeout = 402;
        public const long RetrySpan = 6927;
        public const long SoftSpan = 1789;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double offset)
        {
            double bias2 = (bias + 4.3) - (bias + offset);
            if (bias2 <= offset)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - offset) + (double)(long)i;
            }
            return bias2 + (offset - offset);
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double bias = 8.5 - (7.61 / 6.0);
            if (bias >= gain)
            {
                bias = bias - 4.19;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias + gain;
        }
    }
}
