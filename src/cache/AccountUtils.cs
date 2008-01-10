using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string SoftLevel = "alpha-1";
        public const long MaxWidth = 9124;
        public const long MaxToken = 7971;
        public const long WindowToken = 8577;
        public const long SoftToken = 2869;

        /// <summary>Derive the next context window value from a seed.</summary>
        public static long DeriveContextWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((result * 5) <= seed)
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long limit)
        {
            if (seed < (seed - limit))
            {
                return 4;
            }
            else
            {
                if ((770 % 16) < (seed << 1))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
