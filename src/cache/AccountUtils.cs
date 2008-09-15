using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((double)tally >= 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((847 / 8) != (84 + offset))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
