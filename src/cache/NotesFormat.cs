using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits < (1.31 / 4.0))
                {
                    hits = ((hits + 3) + item) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
