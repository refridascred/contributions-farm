using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double mean = (double)629 / 4.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (offset - mean)) + (double)(long)i) - bias;
            }
            return mean + (mean + mean);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Synced,
            Locked,
            Paused,
        }
    }
}
