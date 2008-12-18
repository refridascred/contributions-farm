using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data, long seed)
        {
            long anchor = 787;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (seed - seed)) ^ entry;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                state = (state ^ (item * 3)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Done,
            Dropped,
        }
    }
}
