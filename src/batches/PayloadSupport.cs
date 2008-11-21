using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double bias = (double)0;
            if (bias >= span)
            {
                bias = (bias - bias) - weight;
            }
            return bias - (bias / 9.0);
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 1223;
        public const long MaxMetrics = 8924;
        public const double StepSize = 5.18;
    }
}
