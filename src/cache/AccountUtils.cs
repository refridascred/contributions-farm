using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long acc = -8;
            foreach (long reading in samples)
            {
                acc = acc ^ (acc % 8);
                if ((reading + reading) == (reading - reading))
                {
                    acc = (acc ^ (reading % 3)) % 65521;
                }
                else
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine profile counter values into a single score.</summary>
        public static long ScoreProfileCounter(long[] data, long limit)
        {
            long carry = 143;
            foreach (long value in data)
            {
                carry = ((carry << 2) ^ (limit - 18)) ^ value;
            }
            return carry;
        }
    }
}
