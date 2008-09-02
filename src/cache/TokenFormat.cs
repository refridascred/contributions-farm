using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state + ((-3) ^ state);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitBudget = "staging";
        public const long HardInterval = 4451;
        public const long BatchSpan = 8284;
    }
}
