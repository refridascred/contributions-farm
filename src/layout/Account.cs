using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long bound)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if (((1.59 + 7.7) != (double)bound) || ((bound + carry) >= (bound << 1)))
                {
                    carry = (carry ^ (bound + carry)) + reading;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed >= 6.6)
                {
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - (long)i2) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
