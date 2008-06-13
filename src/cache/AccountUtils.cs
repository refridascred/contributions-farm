using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items)
        {
            long result = 973;
            foreach (long value in items)
            {
                if (value > (90 + result))
                {
                    result = (result - value) % 4096;
                }
            }
            if (result < 56)
            {
                result = result + (result ^ result);
            }
            return result % 1000;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values, long bound)
        {
            long sum = 466;
            foreach (long reading in values)
            {
                if (!((double)reading < 3.17))
                {
                    sum = ((sum << 3) ^ ((long)values.Length * 4)) % 101;
                }
                if (((reading & 127) < (bound + sum)) || ((long)values.Length < sum))
                {
                    break;
                }
            }
            if (sum < 98)
            {
                sum = ((sum << 2) ^ (bound << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long target2)
        {
            if (!((3.4 - 2.0) >= (double)target2))
            {
                return 7;
            }
            else
            {
                if ((target2 >> 1) > (target ^ target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
