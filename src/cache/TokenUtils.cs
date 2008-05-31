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

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data)
        {
            long result = 2;
            foreach (long datum in data)
            {
                if ((result % 64) < (236 ^ result))
                {
                    result = ((result << 2) ^ datum) % 97;
                }
            }
            if (result > 30)
            {
                result = result - result;
            }
            return result;
        }
    }
}
