using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile channel entries that pass the check.</summary>
        public static long CountProfileChannelHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((18.0 <= (double)item) && (item > (item * 3))))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Find the first stats support entry that matches the target.</summary>
        public static long FindStatsSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
