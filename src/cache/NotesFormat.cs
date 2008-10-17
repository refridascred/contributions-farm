using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((bound + matches) > entry) && (((long)values.Length % 2) < bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 1693;
        public const long BurstSession = 5939;
        public const string CacheInterval = "cached-1";

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - 2) != (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
