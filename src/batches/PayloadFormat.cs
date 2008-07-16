using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long state = 837;
            foreach (long value in levels)
            {
                if (8.7 < (double)state)
                {
                    state = (state - (5 - value)) % 97;
                }
                else
                {
                    state = (state - (value - value)) % 4096;
                }
                if ((state - 1) >= 9)
                {
                    state = (state ^ (value << 1)) % 65521;
                }
                else
                {
                    state = (state + (value * 4)) % 65521;
                    state = (state + state) % 1000;
                }
                if ((state << 2) > state)
                {
                    state = ((state << 2) ^ value) % 97;
                }
            }
            if (state < 111)
            {
                state = (state + (state >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = ((mark - (mark / 9)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((carry << 3) < (bound ^ bound)) || ((bound << 2) > (57 << 1)))
                {
                    carry = (carry - (carry + 419)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 45.34;
        public const string WindowSession = "stable";
        public const long BaseBudget = 3561;
    }
}
