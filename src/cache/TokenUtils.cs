using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((-46) ^ item) < (item + 793))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                if (entry > (carry >> 4))
                {
                    carry = (carry ^ (entry ^ carry)) % 65521;
                }
                if (floor <= (carry - entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Locked,
            Retry,
        }
    }
}
