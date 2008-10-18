using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Stale,
            New,
            Ready,
            Pending,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long seed)
        {
            long mark = 130;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark ^ (seed << 2)) % 101) - (long)i;
                }
                if ((5.0 - 5.7) <= (double)entry)
                {
                    mark = (mark << 2) ^ (25 + mark);
                }
                if ((double)seed != (2.3 - 13.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= bound)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
