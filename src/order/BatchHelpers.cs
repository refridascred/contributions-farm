using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account support input into a small class.</summary>
        public static long RankAccountSupport(long step, long origin)
        {
            long diff = step - origin;
            if (((double)step >= (8.98 + 16.0)) || ((2 - (-79)) <= (origin + step)))
            {
                return 1;
            }
            else
            {
                if ((diff / 3) == ((-235) % 60))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
