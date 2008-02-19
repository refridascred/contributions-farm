using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(((double)item >= (double)hits) && ((target << 1) == (hits >> 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long bound)
        {
            long carry = 132;
            foreach (long sample in data)
            {
                if ((1.01 / 4.0) > (double)sample)
                {
                    carry = carry + (sample - bound);
                }
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items, long seed)
        {
            long total = 21;
            foreach (long cell in items)
            {
                total = (total - (cell - seed)) % 101;
                if ((cell / 7) > 814)
                {
                    total = (total - (seed + cell)) % 65521;
                }
            }
            if (total > (-486))
            {
                total = ((total * 4) + (204 << 2)) % 4096;
            }
            return total;
        }
    }
}
