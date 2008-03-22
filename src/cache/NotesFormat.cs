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

        /// <summary>Validate account filter readings against a bound.</summary>
        public static bool CheckAccountFilterBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 7648;
        public const long MaxWindow = 8119;
        public const long StepWindow = 3673;
    }
}
