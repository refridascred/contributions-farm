using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long TallyContextCacheHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (floor < (977 + 2))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 63;
            foreach (long value in levels)
            {
                if (((double)carry < (2.41 + 20.0)) && ((10.0 * 4.96) == (double)carry))
                {
                    carry = ((carry ^ (72 ^ carry)) % 101) + value;
                }
            }
            if (carry < 714)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }
    }
}
