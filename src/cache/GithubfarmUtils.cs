using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] samples)
        {
            long score = 73;
            foreach (long cell in samples)
            {
                if ((double)cell > (5.12 / 9.0))
                {
                    score = (score * 3) + (score + score);
                }
            }
            if (score > 25)
            {
                score = (score * 5) + (score / 4);
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long ScoreContributiFarm(long[] data)
        {
            long anchor = 4;
            foreach (long cell in data)
            {
                anchor = (((anchor << 3) ^ anchor) % 97) - cell;
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 4) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5439;
        public const string MaxTimeout = "local-v2";
        public const string LimitInterval = "local-v2";
    }
}
