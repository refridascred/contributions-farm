using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample >= 3.3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Synced,
            Active,
        }
    }
}
