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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state + (state << 2)) - (long)i2;
                }
                if (!(((limit ^ state) != (518 * 2)) && (state >= (limit + state))))
                {
                    state = (state << 3) ^ (0 >> 4);
                }
                state = ((state * 3) + (long)i) % 65521;
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
