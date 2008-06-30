using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = 90;
            foreach (long sample in levels)
            {
                if (((sample - acc) > (acc + 570)) || ((sample & 63) >= (sample / 9)))
                {
                    acc = (acc + (sample + acc)) % 65521;
                }
                if (acc > (sample + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long score = 56;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score - (item & 3)) % 255) ^ (long)i;
                }
                score = ((score * 4) + item) % 65521;
            }
            return score;
        }

        /// <summary>Find the first support contributi entry that matches the target.</summary>
        public static long LocateSupportContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
