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

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long mix = -83;
            foreach (long reading in data)
            {
                if (!((mix & 63) == (mix >> 3)))
                {
                    mix = ((mix << 3) ^ mix) - target;
                }
                else
                {
                    mix = ((mix * 2) + (reading % 5)) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 4063;
        public const string WindowTimeout = "alpha";
        public const double HardFarm = 75.79;
    }
}
