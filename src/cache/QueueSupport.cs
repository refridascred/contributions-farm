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

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings, long origin)
        {
            long carry = 36;
            foreach (long reading in readings)
            {
                if ((254 ^ carry) < carry)
                {
                    carry = (((carry + carry) % 97) + reading) + origin;
                }
            }
            return carry;
        }
    }
}
