using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (state - origin)) % 97;
                if (((double)(-71) > (9.0 - 19.0)) && ((double)state != (6.4 / 9.0)))
                {
                    state = state ^ ((long)i - (long)i);
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + origin)) % 4096;
                }
                state = state + ((long)i % 60);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values, long target)
        {
            long carry = 88;
            foreach (long reading in values)
            {
                carry = (carry ^ (target & 15)) - reading;
            }
            return carry % 1000;
        }
    }
}
