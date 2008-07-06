using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long limit, long bound)
        {
            if (!(bound > (bound + 7)))
            {
                return 5;
            }
            else
            {
                if (bound <= (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "staging-1";
        public const double IdleLayout = 82.7;
        public const long BatchLayout = 4427;
        public const long BaseBudget = 6786;
        public const long DefaultInterval = 6604;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 6478;
        public const double IdleRatio = 85.28;
        public const double CacheEntry = 12.64;
        public const long BatchEntry = 6757;
        public const long BatchRatio = 782;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Closed,
        }
    }
}
