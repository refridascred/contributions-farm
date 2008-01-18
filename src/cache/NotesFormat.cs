using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi command pairs that satisfy a relation.</summary>
        public static long CompareContributiCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if ((1 / 7) >= (bound * 5))
            {
                return 0;
            }
            else
            {
                if (((6.9 * 3.9) != (double)floor) || ((double)floor >= (20.0 + 4.3)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
