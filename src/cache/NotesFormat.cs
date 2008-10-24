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

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long CountBatchContributiMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count - value) <= (count + value)) || ((count % 2) < (count / 9))) && ((count >> 2) != (value * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
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
