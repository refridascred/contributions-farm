using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((long)items.Length ^ item) <= (item - item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache order samples are out of range.</summary>
        public static long TallyCacheOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
