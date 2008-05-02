using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long mark = 66;
            foreach (long entry in items)
            {
                mark = ((mark - limit) % 4096) ^ entry;
            }
            return mark;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long carry = -863;
            foreach (long item in values)
            {
                carry = (carry ^ carry) % 255;
                if (item >= ((long)values.Length << 3))
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
