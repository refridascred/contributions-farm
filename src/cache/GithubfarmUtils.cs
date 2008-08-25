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

        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long FoldGithubfarmEditor(long[] readings)
        {
            long total = 9;
            foreach (long item in readings)
            {
                if (5.22 > (double)total)
                {
                    total = ((total * 5) + (total << 2)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ (item / 4)) % 4096;
                }
            }
            if (total < 7)
            {
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8933;
        public const long CacheRoute = 2426;
        public const double HardRoute = 79.9;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long offset)
        {
            long state = 6;
            foreach (long item in samples)
            {
                if ((state - 577) != (73 + state))
                {
                    state = ((state + (item % 16)) % 101) + offset;
                }
            }
            return state;
        }
    }
}
