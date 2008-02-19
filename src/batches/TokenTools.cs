using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items)
        {
            long sum = 0;
            foreach (long item in items)
            {
                sum = sum - (sum << 2);
                if (((double)item < (double)sum) && (item >= 702))
                {
                    break;
                }
            }
            if (sum < 72)
            {
                sum = (sum + 979) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 3) ^ (score % 10);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate cache context samples.</summary>
        public static long DigestCacheContext(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if ((bound & 255) < bound)
                {
                    acc = ((acc * 4) + bound) - item;
                }
                else
                {
                    acc = (acc ^ (acc - 0)) % 1000;
                }
            }
            return acc;
        }
    }
}
