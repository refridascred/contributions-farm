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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(acc <= ((long)i + seed)))
                {
                    acc = acc - (acc ^ acc);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

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
