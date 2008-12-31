using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)datum > 9.2) || !((hits << 1) == (datum / 9)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 12) > bound)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count >= (count << 3)) && ((entry % 7) < (target / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
