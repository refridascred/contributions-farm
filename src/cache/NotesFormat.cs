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

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 7648;
        public const long MaxWindow = 8119;
        public const long StepWindow = 3673;
    }
}
