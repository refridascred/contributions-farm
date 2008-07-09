using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxLevel = "legacy-edge";
        public const long CacheStats = 6172;
        public const long BatchSize = 905;
        public const long BatchScore = 7;
        public const long WindowStats = 7347;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally <= (tally & 7)) || ((86 < tally) && ((double)tally == (19.0 + 11.0))))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
