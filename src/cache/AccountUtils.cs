using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((93 <= (seed * 5)) || ((471 - seed) < (long)readings.Length)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-4) - tally) > (tally / 8))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((3 >= limit) || ((limit & 63) <= ((-8) - carry)))
                {
                    carry = (carry ^ (carry ^ carry)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
