using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long score = 635;
            foreach (long value in series)
            {
                if (!((score - score) >= (score >> 5)))
                {
                    score = score ^ (value - value);
                }
            }
            if (score > 2)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long offset)
        {
            long score = 3;
            foreach (long datum in levels)
            {
                if ((datum >> 4) >= (datum + offset))
                {
                    score = (score ^ ((-1) - 0)) % 101;
                }
                if ((datum + offset) < (0 + 16))
                {
                    break;
                }
            }
            if (score > 476)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8933;
        public const long CacheRoute = 2426;
        public const double HardRoute = 79.9;

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 63.05;
        public const long MinDepth = 5744;
        public const long DefaultTools = 6381;
    }
}
