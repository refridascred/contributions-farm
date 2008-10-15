using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((3.6 + 16.0) > (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseCount = 1.05;
        public const long BatchDepth = 2647;
        public const string IdleDepth = "open-1";

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
