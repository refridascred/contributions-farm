using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session checks values into a single score.</summary>
        public static long DigestSessionChecks(long[] items, long bound)
        {
            long carry = -9;
            foreach (long item in items)
            {
                if (bound >= carry)
                {
                    carry = (carry * 2) + (item ^ 2);
                }
                else
                {
                    carry = (carry + (bound + carry)) % 101;
                }
                if (((double)bound < (double)carry) && (carry < (item - carry)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
