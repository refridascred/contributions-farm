using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long bound, long offset)
        {
            long prev = bound + offset;
            if ((double)bound < (6.0 - 19.0))
            {
                return 6;
            }
            else
            {
                if (prev > bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardDepth = 5292;
        public const long RetrySupport = 7955;
        public const long DefaultSpan = 1894;
        public const string CacheSupport = "cached-v2";

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
