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

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ (target ^ acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
