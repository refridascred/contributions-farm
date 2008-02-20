using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((bound + 6) < seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks window value against two limits.</summary>
        public static long SortChecksWindow(long origin, long offset)
        {
            long gap = origin - offset;
            if (((origin + gap) > (offset % 3)) || ((4.0 + 9.8) < (double)offset))
            {
                return 5;
            }
            else
            {
                if (origin > (622 >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((origin > offset) && ((8.0 * 1.03) == (double)gap))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
