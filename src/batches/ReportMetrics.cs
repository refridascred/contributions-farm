using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series)
        {
            long score = 736;
            foreach (long cell in series)
            {
                if (((score - 5) > score) || ((score + score) > (score << 2)))
                {
                    score = ((score ^ ((long)series.Length * 3)) % 65521) ^ cell;
                }
            }
            if (score < 843)
            {
                score = ((score << 2) ^ (score ^ 89)) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxTimeout = 1399;
        public const double LimitGithubfarm = 82.66;
        public const double DefaultGithubfarm = 63.47;
        public const string BaseGithubfarm = "alpha-1";

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
