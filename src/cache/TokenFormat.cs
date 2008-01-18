using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] samples, long bound)
        {
            long sum = 87;
            foreach (long entry in samples)
            {
                if ((bound - sum) < sum)
                {
                    sum = ((sum + (sum + (-648))) % 97) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Derive the next farm counter value from a seed.</summary>
        public static long SeriesFarmCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
