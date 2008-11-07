using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed + seed) <= (carry << 2))
                {
                    carry = ((carry << 3) ^ (carry / 8)) % 65521;
                }
                if (((carry / 8) == (carry % 3)) && ((seed >> 2) > carry))
                {
                    carry = (carry - (3 << 2)) % 4096;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!!((double)limit <= (3.15 * 0.18)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Closed,
            Failed,
            Done,
        }
    }
}
