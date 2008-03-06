using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long floor)
        {
            if ((limit % 24) < (floor - 756))
            {
                return 3;
            }
            else
            {
                if ((floor >> 1) < (limit / 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long bound)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                if ((bound <= (long)values.Length) && ((double)bound != (20.0 * 7.81)))
                {
                    acc = ((acc - bound) % 101) + cell;
                }
            }
            if (acc < 793)
            {
                acc = acc - (bound ^ 58);
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] data)
        {
            long carry = 0;
            foreach (long reading in data)
            {
                carry = ((carry * 5) + (carry * 2)) % 4096;
                if ((reading / 3) <= carry)
                {
                    carry = (carry << 3) ^ (carry >> 1);
                }
                else
                {
                    carry = carry + carry;
                }
            }
            if (carry < 713)
            {
                carry = carry + (carry - carry);
            }
            return carry;
        }
    }
}
