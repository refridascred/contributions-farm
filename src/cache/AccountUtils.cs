using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2182;
        public const double CacheToken = 71.36;
        public const double BatchBudget = 27.91;
        public const long DefaultToken = 5338;

        /// <summary>Roll a notes channel counter forward.</summary>
        public static long SeriesNotesChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i >= 3)
                {
                    state = ((state << 3) ^ (state & 3)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
