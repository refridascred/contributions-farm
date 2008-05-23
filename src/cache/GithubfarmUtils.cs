using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - (origin / 7)) % 4096;
                carry = (carry + (973 & 15)) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items, long bound)
        {
            long mix = 327;
            foreach (long datum in items)
            {
                mix = ((mix ^ (mix & 7)) + datum) + bound;
            }
            return mix;
        }

        /// <summary>Iterate the cache batches series from a seed.</summary>
        public static long DeriveCacheBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (score <= (target + target))
                {
                    continue;
                }
                else
                {
                    score = (score + score) % 4096;
                }
                score = (score * 3) + ((long)i - 489);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
