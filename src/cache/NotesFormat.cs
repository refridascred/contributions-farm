using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long offset, long seed)
        {
            if (seed < (offset + offset))
            {
                return 5;
            }
            else
            {
                if (offset <= (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (((3.0 + 7.0) == (double)offset) && ((offset + offset) < (offset >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit cache contributi readings against a rule.</summary>
        public static long MeasureCacheContributiMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits >= (hits + 54))
                {
                    hits = ((hits + 1) - datum) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks report entry stays within the limit.</summary>
        public static bool CheckChecksReportBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
