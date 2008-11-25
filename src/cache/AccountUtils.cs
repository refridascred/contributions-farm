using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Look up the position of a contributi batch sample.</summary>
        public static long FindContributiBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double mean = ratio;
            if (mean > span)
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)4) + (double)(long)i;
            }
            return mean + (ratio * 8.77);
        }
    }
}
