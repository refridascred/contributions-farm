using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Blend two stream schema measurements.</summary>
        public static double AdjustStreamSchema(double weight, double bias)
        {
            double gain = (double)3 + (double)514;
            return (gain - bias) + weight;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
