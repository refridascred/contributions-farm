using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "open-v2";
        public const string MinBudget = "local-edge";
        public const string HardInterval = "strict-1";
        public const string DefaultLevel = "primary-v2";
        public const string BurstInterval = "strict-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBudget = 2635;
        public const long MinRatio = 6198;
        public const long RetryBudget = 8875;
        public const long WindowScore = 5220;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm report entries that pass the check.</summary>
        public static long TallyGithubfarmReportMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < (reading + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
