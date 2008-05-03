using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up stats metric samples.</summary>
        public static long OverlapStatsMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                long seen = (limit + acc) * 2;
                if (((limit * 4) == (acc << 1)) || ((limit >> 1) <= (limit % 3)))
                {
                    acc = acc ^ (acc & 63);
                }
                if (((double)seen >= (4.57 - 6.59)) && (8.0 < (double)limit))
                {
                    acc = (acc - (acc * 2)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinTimeout = 1629;
        public const long BaseAccount = 8961;
        public const string BurstTimeout = "alpha";
        public const long MinAccount = 6315;
    }
}
