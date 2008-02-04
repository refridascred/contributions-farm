using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long limit)
        {
            long state = 266;
            foreach (long value in items)
            {
                state = ((state ^ (limit - (long)items.Length)) % 4096) + value;
            }
            if (state < 7)
            {
                state = (state << 2) ^ (limit - state);
            }
            return state % 4096;
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long StepLayoutOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - 21) > (target + target)))
                {
                    result = (result + (target * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 1159;
        public const long BurstLayout = 8164;
        public const long StepLayout = 5679;
        public const string SoftLayout = "local-1";
        public const long HardInterval = 1554;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "cached-1";
        public const double LimitInterval = 64.62;
        public const string SoftAlready = "primary-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 2633;
        public const long BaseEntry = 3885;
        public const long LimitEntry = 2174;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((8 + 6) <= (offset - carry)) || (offset > (offset / 6)))
                {
                    carry = carry - offset;
                    carry = (carry ^ ((long)i - carry)) % 65521;
                }
                if (((offset * 2) != (4 - offset)) && ((double)offset != (5.89 + 6.1)))
                {
                    carry = (carry - (carry * 4)) % 101;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
