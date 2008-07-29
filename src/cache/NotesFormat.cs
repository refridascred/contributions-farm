using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 5) <= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long origin)
        {
            if (!((7.0 - 1.0) != (double)bound))
            {
                return 3;
            }
            else
            {
                if ((bound & 15) < (origin ^ bound))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
