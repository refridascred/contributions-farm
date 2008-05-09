using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double weight = bias;
            return (weight + bias) + bias2;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
