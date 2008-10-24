using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "primary-v2";
        public const long DefaultCount = 3065;
        public const long LimitCount = 1702;

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long TallyFarmWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < (4.0 * 8.71))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((7 * 4) <= step)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
