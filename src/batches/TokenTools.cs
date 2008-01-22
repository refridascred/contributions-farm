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

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "latest-v2";
        public const long BatchReport = 4011;
        public const long StepReport = 4826;
        public const string SoftCount = "staging";

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
