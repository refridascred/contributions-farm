using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double mean = 6.2;
            if (mean >= (span / 6.0))
            {
                mean = mean + span;
            }
            return mean + gain;
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
