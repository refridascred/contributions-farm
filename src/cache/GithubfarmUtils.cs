using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const long IdleInterval = 5136;
        public const long StepSupport = 7093;
        public const long BurstDepth = 2050;
        public const double MaxSpan = 53.47;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long limit)
        {
            long score = 0;
            foreach (long entry in values)
            {
                if ((double)limit < (double)entry)
                {
                    score = (score + limit) % 97;
                }
            }
            return score;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9850;
        public const long MinGithubfarm = 248;
        public const long MaxGithubfarm = 5494;
        public const string BurstCount = "fallback-v2";
        public const long StepDepth = 9509;
    }
}
