using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the contributi stats entries that pass the check.</summary>
        public static long CountContributiStatsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 1) >= (item / 9))
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer editor entry that matches the target.</summary>
        public static long FindBufferEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = (acc + (item ^ target)) % 4096;
                if (((long)values.Length - target) >= 97)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
