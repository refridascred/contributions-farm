using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first order commits entry that matches the target.</summary>
        public static long LocateOrderCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream editor readings.</summary>
        public static long WeighStreamEditor(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = state ^ (state - entry);
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (9.66 + 7.9)) && ((double)entry <= (9.8 * 0.48)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
