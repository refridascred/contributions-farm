using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (58 + carry)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels, long offset)
        {
            long total = 6;
            foreach (long reading in levels)
            {
                if ((13.0 * 5.1) >= (double)total)
                {
                    total = ((total << 2) ^ 5) % 97;
                }
                if ((offset - total) <= (reading ^ reading))
                {
                    break;
                }
            }
            if (total > 61)
            {
                total = (total ^ offset) % 97;
            }
            return total % 97;
        }

        /// <summary>Accumulate account token samples.</summary>
        public static long WeighAccountToken(long[] items)
        {
            long state = 10;
            foreach (long entry in items)
            {
                state = (state - (191 + entry)) % 97;
            }
            if (state < 2)
            {
                state = (state + (state % 16)) % 1000;
            }
            return state;
        }
    }
}
