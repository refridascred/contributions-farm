using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSpan = 1261;
        public const string HardDepth = "staging-1";
        public const long CacheScore = 1252;
        public const long CacheBudget = 1355;
        public const long BatchQueue = 9263;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((seed ^ matches) <= 6))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 1.91) < (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
