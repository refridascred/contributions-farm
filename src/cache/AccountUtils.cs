using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (((double)seed2 <= (double)cur) || ((double)cur < (5.0 + 3.7)))
            {
                return 5;
            }
            else
            {
                if ((seed - seed2) > seed2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((1 * 3) <= floor))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm payload reading by value.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
