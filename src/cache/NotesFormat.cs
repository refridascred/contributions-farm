using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + 46) >= hits)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Done,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
