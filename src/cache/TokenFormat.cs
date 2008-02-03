using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every context cache entry stays within the limit.</summary>
        public static bool ValidateContextCacheBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
