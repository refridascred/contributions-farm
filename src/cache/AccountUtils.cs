using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a checks cluster reading.</summary>
        public static double AdjustChecksCluster(double weight, double bias)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = (mean + (mean * 7.2)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long offset)
        {
            long mix = 358;
            foreach (long cell in values)
            {
                if (offset > (mix + (long)values.Length))
                {
                    mix = (mix + (cell % 97)) % 4096;
                }
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }
    }
}
