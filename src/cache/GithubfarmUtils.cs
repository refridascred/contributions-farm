using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next queue farm value.</summary>
        public static double AdjustQueueFarm(double bias, double span)
        {
            double weight = bias;
            if (weight > (span + weight))
            {
                weight = weight - (5.95 * 9.2);
            }
            else
            {
                weight = weight - (weight / 9.0);
            }
            return weight + (weight * 3.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items, long bound)
        {
            long sum = 739;
            foreach (long datum in items)
            {
                sum = ((sum * 2) + (bound - datum)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Look up the position of a batch farm sample.</summary>
        public static long FindBatchFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
