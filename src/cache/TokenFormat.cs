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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                if ((mark << 3) == (mark / 4))
                {
                    mark = ((mark << 2) ^ (item - item)) % 4096;
                }
                else
                {
                    mark = (mark - (item % 100)) % 65521;
                }
                if (((double)mark >= (2.5 + 5.23)) && ((item >> 5) > 6))
                {
                    break;
                }
            }
            if (mark < (-14))
            {
                mark = ((mark * 2) + (mark + mark)) % 1000;
            }
            return mark % 97;
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
