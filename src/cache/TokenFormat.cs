using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank batch cluster input into a small class.</summary>
        public static long BucketBatchCluster(long limit, long floor)
        {
            if ((limit % 100) <= (limit >> 1))
            {
                return 2;
            }
            else
            {
                if ((limit + floor) == (floor & 31))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ (total & 63);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (7.0 * 4.85);
        }
    }
}
