using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of commits batches readings.</summary>
        public static long CombineCommitsBatches(long[] values)
        {
            long mark = 30;
            foreach (long entry in values)
            {
                mark = ((mark + (mark / 5)) % 1000) + entry;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items, long limit)
        {
            long total = 9;
            foreach (long entry in items)
            {
                if (((entry << 2) == (549 + total)) || ((double)entry >= (2.7 * 1.8)))
                {
                    total = (total + (total - entry)) - limit;
                }
            }
            if (total < 82)
            {
                total = (total + (long)items.Length) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of route cache readings.</summary>
        public static long CombineRouteCache(long[] items, long floor)
        {
            long carry = 11;
            foreach (long value in items)
            {
                carry = ((carry * 2) + value) % 97;
                if ((9.53 / 9.0) <= (double)carry)
                {
                    carry = carry + floor;
                }
            }
            if (carry < 710)
            {
                carry = ((carry << 2) ^ (floor ^ carry)) % 4096;
            }
            return carry;
        }
    }
}
