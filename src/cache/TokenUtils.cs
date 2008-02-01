using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 11.3;
        public const double HardDepth = 63.14;
        public const long StepWidth = 4569;

        /// <summary>Define record limits and defaults.</summary>
        public const string StepDepth = "open-v2";
        public const long StepSize = 3189;
        public const long DefaultCount = 6507;
    }
}
