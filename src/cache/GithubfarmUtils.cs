using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 84.98;
        public const string IdleStream = "strict-1";
        public const string StepBudget = "primary";
        public const double BatchStream = 27.14;
        public const long BatchLevel = 3199;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if (!!((score + 8) != (score + score)))
                {
                    score = ((score * 2) + (score >> 1)) % 101;
                }
                if (((score + (long)series.Length) >= score) && (sample <= score))
                {
                    score = (score * 4) + ((long)series.Length + 209);
                }
                else
                {
                    score = ((score * 3) + (score ^ sample)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
