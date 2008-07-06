using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long total = 68;
            foreach (long datum in levels)
            {
                if (((total + datum) <= (3 << 2)) && ((total - total) <= datum))
                {
                    total = total + (total >> 5);
                }
            }
            return total;
        }

        /// <summary>Find the first stats support entry that matches the target.</summary>
        public static long LookupStatsSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] levels, long step)
        {
            long anchor = 117;
            foreach (long cell in levels)
            {
                anchor = (((anchor << 2) ^ (step % 16)) % 65521) ^ cell;
            }
            return anchor % 1000;
        }
    }
}
