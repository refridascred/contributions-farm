using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item >> 1) <= (long)data.Length)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 9725;
        public const long MaxCluster = 7822;
        public const long CacheCluster = 3986;
        public const long StepCluster = 156;
        public const double HardCluster = 10.42;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 96.62;
        public const long StepDepth = 7021;
        public const long RetryGithubfarm = 9045;
        public const string StepGithubfarm = "strict";
        public const long SoftTimeout = 9456;
    }
}
