using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double weight2 = offset - (weight - weight);
            if (weight2 >= (double)18)
            {
                weight2 = weight2 - 1.5;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight + offset)) + (double)(long)i;
            }
            return weight2 - offset;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
