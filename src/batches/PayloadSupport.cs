using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = bias2;
            return (mean - 13.0) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftSpan = "stable";
        public const long BatchDepth = 1961;
        public const double BurstRatio = 92.47;
        public const long DefaultSpan = 8564;

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long acc = 288;
            foreach (long entry in samples)
            {
                if ((double)entry <= (6.31 + 4.8))
                {
                    acc = ((acc * 2) + (acc << 1)) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }
    }
}
