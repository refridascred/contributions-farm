using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long offset)
        {
            long carry = 665;
            foreach (long value in items)
            {
                if ((value / 2) != (carry / 7))
                {
                    carry = (carry + offset) % 255;
                }
                else
                {
                    carry = (carry - carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((2.3 - 0.49) == (double)origin)
                {
                    long delta = (long)i;
                    state = ((state << 2) ^ (state + delta)) % 65521;
                }
                state = ((state * 5) + (state + (long)i)) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
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
