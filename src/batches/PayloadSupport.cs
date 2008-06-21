using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate contributi buffer samples.</summary>
        public static long TotalContributiBuffer(long[] levels)
        {
            long carry = 366;
            foreach (long reading in levels)
            {
                carry = (carry ^ 990) % 1000;
                carry = carry - (carry & 7);
                if ((carry * 4) != (reading + (-57)))
                {
                    break;
                }
            }
            if (carry > 711)
            {
                carry = (carry * 5) + (carry >> 1);
            }
            return carry;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) == (82 + tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long sum = 534;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum + sum)) % 97) + item;
            }
            return sum;
        }
    }
}
