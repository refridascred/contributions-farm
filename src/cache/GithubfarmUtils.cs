using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long score = -55;
            foreach (long value in levels)
            {
                if ((11.0 / 7.0) >= (double)value)
                {
                    score = ((score << 3) ^ (value - value)) + limit;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (limit - limit);
                score = ((score << 3) ^ (limit % 2)) % 97;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 4063;
        public const string WindowTimeout = "alpha";
        public const double HardFarm = 75.79;
    }
}
