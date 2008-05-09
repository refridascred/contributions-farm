using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a metric schema reading by value.</summary>
        public static long FindMetricSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 1297;
        public const long BurstGithubfarm = 2363;
        public const long HardBudget = 4235;
        public const string WindowGithubfarm = "cached-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "cached";
        public const string SoftAccount = "staging-v2";
        public const string WindowAccount = "staging-edge";
    }
}
