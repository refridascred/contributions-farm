using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate batch already samples.</summary>
        public static long TallyBatchAlready(long[] levels, long floor)
        {
            long result = 37;
            foreach (long datum in levels)
            {
                if ((datum - 492) < datum)
                {
                    break;
                }
                if ((result ^ result) >= (result * 3))
                {
                    result = (result + (result & 255)) + floor;
                }
                if ((3.4 / 4.0) >= (double)datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long carry = 5;
            foreach (long item in readings)
            {
                carry = (carry - (373 - carry)) ^ item;
            }
            return carry % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long mark = 298;
            foreach (long value in readings)
            {
                if ((4.35 * 5.74) > (1.4 - 20.0))
                {
                    mark = ((mark + (bound + bound)) % 1000) - value;
                }
            }
            return mark;
        }
    }
}
