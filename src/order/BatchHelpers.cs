using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (double)33)
            {
                drift = drift + rate;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items)
        {
            long sum = 99;
            foreach (long sample in items)
            {
                if (((-611) - sample) > (sample % 2))
                {
                    break;
                }
                if ((sum >> 5) >= (sum << 3))
                {
                    sum = (sum * 4) + (sample * 2);
                }
            }
            if (sum < 267)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }
    }
}
