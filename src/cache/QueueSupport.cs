using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (14.0 >= (double)hits)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 748;
        public const string MinRoute = "strict";
        public const long RetryRoute = 2212;
        public const long CacheRoute = 3569;
        public const string MaxLevel = "stable-1";
    }
}
