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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Synced,
            Paused,
            Draft,
            Dropped,
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
