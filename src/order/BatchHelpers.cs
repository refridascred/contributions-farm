using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a token window reading by value.</summary>
        public static long LocateTokenWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long target)
        {
            long slot = floor - target;
            if ((double)target >= (2.7 * 6.4))
            {
                return 8;
            }
            else
            {
                if ((slot + 79) > (floor * 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] data)
        {
            long state = 725;
            foreach (long item in data)
            {
                state = (state + (item - item)) % 101;
                if ((245 - item) >= (item ^ item))
                {
                    state = (state - 466) % 97;
                }
            }
            return state % 97;
        }
    }
}
