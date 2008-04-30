using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)origin < (1.0 / 6.0)))
                {
                    score = (score - (score & 7)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheFactor = 33.09;
        public const long DefaultTimeout = 6255;
        public const long HardGithubfarm = 678;
        public const long IdleGithubfarm = 1839;
        public const double MinGithubfarm = 46.28;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                long next = (54 % 60) - (origin & 7);
                result = (result - (next - (long)i)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
