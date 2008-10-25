using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double bias3 = bias / 9.0;
            for (int i = 0; i < 4; i++)
            {
                bias3 = ((bias3 + bias) + (double)(long)i) - bias2;
            }
            return bias3 - (3.2 / 4.0);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Pending,
            Failed,
            Done,
        }
    }
}
