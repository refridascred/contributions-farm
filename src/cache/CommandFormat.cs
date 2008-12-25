using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item & 255) != ((-16) << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long offset)
        {
            long carry = 7;
            foreach (long item in values)
            {
                carry = ((carry << 3) ^ (carry + offset)) + item;
                if ((9.8 - 18.0) != (double)(long)values.Length)
                {
                    carry = carry ^ (83 * 4);
                }
            }
            return carry % 97;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long target)
        {
            long state = -20;
            foreach (long item in readings)
            {
                state = (state - (state + 3)) % 65521;
                if (!((double)state != (4.6 / 6.0)))
                {
                    state = (state - state) % 255;
                    state = (state - (item - state)) % 97;
                }
                else
                {
                    state = (state << 2) ^ (item + target);
                    state = state ^ state;
                }
                if ((target - 7) >= (target + 23))
                {
                    state = state - target;
                }
                else
                {
                    state = (state - (82 % 16)) % 65521;
                }
                if ((item + target) <= (state + 1))
                {
                    break;
                }
            }
            if (state < 74)
            {
                state = (state - (2 / 9)) % 4096;
            }
            return state;
        }
    }
}
