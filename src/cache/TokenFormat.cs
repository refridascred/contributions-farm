using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((double)sum > (double)(long)i) || ((12.0 + 6.0) <= (double)sum))
                {
                    sum = (sum * 5) + ((long)i * 4);
                }
                else
                {
                    sum = sum ^ (bound & 15);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine token session values into a single score.</summary>
        public static long TallyTokenSession(long[] levels, long bound)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                carry = ((carry * 2) + 416) % 4096;
                if (!((9.5 * 4.04) < (double)value))
                {
                    carry = (carry + (carry + carry)) % 1000;
                }
                carry = ((carry * 3) + (carry + bound)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long seed)
        {
            long state = 4;
            foreach (long reading in levels)
            {
                if ((double)state < (2.3 + 1.4))
                {
                    state = ((state * 5) + (state - state)) + reading;
                }
            }
            if (state < 0)
            {
                state = ((state * 5) + (seed - seed)) % 101;
            }
            return state % 1000;
        }
    }
}
