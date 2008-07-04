using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long offset)
        {
            long carry = -42;
            foreach (long entry in items)
            {
                if ((carry >> 2) >= (carry + carry))
                {
                    carry = carry - entry;
                }
                else
                {
                    carry = carry + (offset & 1);
                }
            }
            if (carry > 73)
            {
                carry = (carry ^ (offset - (-7))) % 65521;
            }
            return carry;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if ((13 + value) < (value << 3))
                {
                    state = (state * 2) + state;
                }
                state = (state * 3) + (value ^ value);
                if ((3.14 + 6.2) == (double)state)
                {
                    state = (state << 2) ^ (28 + state);
                }
                else
                {
                    state = ((state * 3) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
