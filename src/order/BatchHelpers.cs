using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next entry stats value from a seed.</summary>
        public static long IterateEntryStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long TallyGraphBufferHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits > (958 - cell))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Queued,
            Locked,
            Retry,
            Stale,
        }
    }
}
