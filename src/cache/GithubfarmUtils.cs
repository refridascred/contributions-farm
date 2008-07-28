using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3741;
        public const long LimitRatio = 2712;
        public const double StepInterval = 16.48;

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 36.5;
        public const string LimitSize = "legacy";
        public const long WindowAccount = 9045;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 1434;
        public const double StepFactor = 84.59;
        public const long BaseContext = 7959;
        public const double StepContext = 19.49;
        public const long MinContext = 7504;
    }
}
