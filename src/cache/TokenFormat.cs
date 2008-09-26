using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Label { get; set; }
            public double Size { get; set; }
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
