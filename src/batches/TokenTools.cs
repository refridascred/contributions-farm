using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheGithubfarm = "strict";
        public const long HardGithubfarm = 6325;
        public const double StepGithubfarm = 87.37;
        public const long MinGithubfarm = 5599;
        public const long BatchScore = 4452;
    }
}
