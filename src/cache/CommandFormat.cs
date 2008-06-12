using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (4.0 - 10.0))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
