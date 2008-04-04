using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Active,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches + matches) >= (9 ^ reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
