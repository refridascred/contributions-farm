using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5762;
        public const double IdleWidth = 74.66;
        public const long WindowProfile = 2164;
        public const long BurstProfile = 7877;

        /// <summary>Roll a session command counter forward.</summary>
        public static long DeriveSessionCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long SeriesGithubfarmRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score * 4) + (score >> 2)) + (long)i2;
                }
                if ((7.1 - 3.4) > (double)score)
                {
                    score = score + (score - seed);
                }
                if (!((long)i <= score))
                {
                    score = score + (seed / 8);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
