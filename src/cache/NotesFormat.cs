using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items, long bound)
        {
            long carry = 785;
            foreach (long reading in items)
            {
                if (reading < (carry * 3))
                {
                    carry = ((carry << 2) ^ reading) - bound;
                }
            }
            return carry;
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
