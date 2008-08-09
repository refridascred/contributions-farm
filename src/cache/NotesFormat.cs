using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels, long origin)
        {
            long acc = 12;
            foreach (long datum in levels)
            {
                acc = (acc - origin) - datum;
                if (((17.0 / 6.0) != (double)acc) && ((double)origin <= (2.3 - 12.0)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((16 * 4) <= (cell + cell))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
