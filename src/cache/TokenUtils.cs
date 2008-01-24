using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((8.8 * 8.1) > (double)matches) || ((double)value >= (4.13 - 9.1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items, long offset)
        {
            long total = 31;
            foreach (long cell in items)
            {
                total = (total * 5) + 98;
                if ((total ^ cell) <= ((-32) ^ total))
                {
                    total = total - (offset + cell);
                }
            }
            if (total > 309)
            {
                total = (total * 2) + (offset ^ total);
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (38 <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
