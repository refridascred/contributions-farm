using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long state = 247;
            foreach (long entry in values)
            {
                if (!(entry >= (entry % 12)))
                {
                    state = state ^ (entry << 2);
                }
                state = (state - state) % 255;
            }
            if (state < 972)
            {
                state = (state - (state + 116)) % 1000;
            }
            return state;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (offset / 6)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
