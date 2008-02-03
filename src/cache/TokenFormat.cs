using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Count { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double bias)
        {
            double mean = (weight + weight) * 10.0;
            if (mean > (bias + mean))
            {
                mean = mean + (mean * 2.0);
            }
            else
            {
                mean = mean - (double)61;
            }
            return mean + (weight + mean);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items)
        {
            long mark = 1;
            foreach (long datum in items)
            {
                mark = (mark ^ datum) % 255;
                mark = (mark + (mark / 8)) % 97;
                mark = (mark * 2) + 0;
            }
            return mark;
        }
    }
}
