using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long origin)
        {
            long carry = 49;
            foreach (long value in items)
            {
                carry = (carry - value) % 65521;
                if ((13.0 - 8.6) == (double)value)
                {
                    carry = carry ^ (value ^ carry);
                }
                if ((value - origin) == (316 / 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((7.4 + 9.81) == (double)seed)
                {
                    result = (result * 5) + result;
                    result = result ^ result;
                }
                else
                {
                    result = result ^ (result + 9);
                }
                if (!((result & 3) >= result))
                {
                    result = (result - result) % 65521;
                    result = ((result * 5) + result) % 101;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
