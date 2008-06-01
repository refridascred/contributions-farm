using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample >= count)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Stale,
            Closed,
            Active,
        }
    }
}
