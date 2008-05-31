using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 253;
            foreach (long entry in items)
            {
                carry = carry - carry;
                if (((12 ^ 256) > entry) || ((carry & 7) > (carry - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (entry % 60)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((7 & 63) >= ((long)i << 1))
                {
                    state = (state ^ (long)i) % 4096;
                }
                state = ((state << 2) ^ (seed << 1)) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples)
        {
            long state = 77;
            foreach (long reading in samples)
            {
                state = ((state * 3) + (state ^ reading)) % 1000;
            }
            if (state > 897)
            {
                state = ((state * 5) + (state ^ 939)) % 65521;
            }
            return state % 97;
        }
    }
}
