using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits % 5) > reading) || (reading < (reading & 7)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
