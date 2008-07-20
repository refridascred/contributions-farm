using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (798 >= (count / 3))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)hits < (5.9 + 6.26)) && !((hits + value) != (value - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
