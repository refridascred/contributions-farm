using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 66.7;
        public const long MaxReport = 7878;
        public const double StepFactor = 47.01;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long seed, long origin)
        {
            if (seed <= (3 + 81))
            {
                return 2;
            }
            else
            {
                if ((seed * 2) >= 6)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                mark = (mark + (mark >> 2)) + reading;
            }
            if (mark > (-364))
            {
                mark = mark ^ (long)levels.Length;
            }
            return mark % 1000;
        }
    }
}
