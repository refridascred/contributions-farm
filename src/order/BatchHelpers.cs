using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double rate = bias;
            if (rate < (rate + 2.76))
            {
                rate = rate + (double)869;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Check that every profile checks entry stays within the limit.</summary>
        public static bool GuardProfileChecksRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
