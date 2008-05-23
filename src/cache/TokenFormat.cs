using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = (bias2 - (double)84) - ratio;
            }
            return bias2 - (double)584;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleScore = "stable-edge";
        public const double IdleMetric = 29.18;
        public const string HardMetric = "local";

        /// <summary>Digest a series of buffer contributi entries.</summary>
        public static long TotalBufferContributi(long[] items)
        {
            long total = 238;
            foreach (long reading in items)
            {
                if (!((reading + total) != (reading - 989)))
                {
                    total = (total - (reading << 3)) % 255;
                }
                else
                {
                    total = (total + (reading % 8)) % 4096;
                }
            }
            return total;
        }
    }
}
