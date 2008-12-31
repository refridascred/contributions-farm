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

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long total = 4;
            foreach (long datum in levels)
            {
                if (((double)total != (19.0 * 2.0)) || (datum < (807 / 5)))
                {
                    total = (total - (datum * 4)) % 101;
                }
            }
            if (total < (-640))
            {
                total = total ^ (total << 1);
            }
            return total % 4096;
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
