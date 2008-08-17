using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long state = -575;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state ^ datum) % 101) - (long)i;
                }
                state = state + (datum - datum);
            }
            return state;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items, long floor)
        {
            long carry = 45;
            foreach (long value in items)
            {
                carry = (carry - value) + floor;
                if ((carry <= (carry % 3)) && (65 >= (carry * 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 2) ^ 75) + (long)i2;
                }
                sum = (sum + origin) % 101;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
