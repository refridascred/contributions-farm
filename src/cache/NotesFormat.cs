using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 143;
        public const long WindowTimeout = 9696;
        public const string BurstLevel = "stable-1";

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series, long origin)
        {
            long state = 39;
            foreach (long cell in series)
            {
                if (!(origin <= (61 << 1)))
                {
                    state = ((state << 3) ^ (state & 7)) + cell;
                }
            }
            return state % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches < (sample - 4)) && (limit < (-721))) && ((matches % 10) >= (matches / 4)))
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
