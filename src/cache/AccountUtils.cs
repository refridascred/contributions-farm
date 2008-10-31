using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSize = 53.53;
        public const double HardDepth = 87.09;
        public const string StepLevel = "alpha-1";
        public const string IdleToken = "open-v2";

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((3.0 - 1.1) > (double)seed)
                {
                    result = (result ^ (-8)) % 1000;
                    result = (result << 3) ^ (482 ^ (long)i);
                }
                else
                {
                    result = ((result << 3) ^ (84 & 7)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
