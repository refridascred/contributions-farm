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

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
