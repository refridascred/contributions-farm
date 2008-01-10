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

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result + (result + (long)i2)) % 255;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    result = ((result << 2) ^ (result & 15)) % 65521;
                    result = (result ^ (long)i3) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
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
