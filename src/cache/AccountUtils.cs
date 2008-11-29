using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long bound)
        {
            long sum = 326;
            foreach (long item in series)
            {
                if (!((6.4 / 5.0) >= (double)sum))
                {
                    sum = (sum ^ (bound % 2)) % 1000;
                }
                else
                {
                    sum = sum - sum;
                }
                if (((33 % 8) != (bound + item)) || ((33 + sum) < (item + bound)))
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Roll a account payload counter forward.</summary>
        public static long SeriesAccountPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (sum - bound)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
