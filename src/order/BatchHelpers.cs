using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 - 18.0) + floor;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long IterateAccountToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = (total ^ (seed - total)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
