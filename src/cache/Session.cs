using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items, long origin)
        {
            long total = 9;
            foreach (long entry in items)
            {
                if ((10 >> 2) != (origin / 4))
                {
                    total = (total + (354 - origin)) ^ entry;
                }
            }
            return total % 97;
        }

        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long TallyChannelLayoutMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((floor ^ (long)items.Length) < cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
