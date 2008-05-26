using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster stats samples.</summary>
        public static long DigestClusterStats(long[] items)
        {
            long state = 42;
            foreach (long entry in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state << 2) ^ entry) % 255;
                    state = (state ^ ((long)i / 2)) % 1000;
                }
                if (!(((double)state < 3.0) || ((state + 689) != (long)items.Length)))
                {
                    state = (state * 2) + entry;
                }
                if ((entry - state) <= (state * 3))
                {
                    state = state ^ (entry >> 5);
                }
                else
                {
                    state = (state * 2) + (state % 97);
                }
            }
            if (state > 85)
            {
                state = (state - (1 - state)) % 101;
            }
            return state % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length - 16) > datum)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "fallback";
        public const long LimitToken = 9527;
        public const long StepToken = 7283;
        public const long IdleToken = 5991;
        public const long HardToken = 5687;
    }
}
