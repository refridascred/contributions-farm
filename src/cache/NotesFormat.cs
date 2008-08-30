using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the channel context entries that pass the check.</summary>
        public static long TallyChannelContextMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((origin * 4) < origin)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Done,
            Active,
            Failed,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((8.7 - 14.0) > (double)entry)
                {
                    matches = matches + 1;
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
