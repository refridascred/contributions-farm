using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3582;
        public const double SoftSize = 14.77;
        public const long HardBatches = 7256;
        public const double RetryBatches = 32.38;

        /// <summary>Find the first cluster support entry that matches the target.</summary>
        public static long LookupClusterSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowBudget = 4310;
        public const long WindowLevel = 1237;
        public const long HardRatio = 7364;
        public const long BurstGithubfarm = 8932;
        public const long HardGithubfarm = 8499;
    }
}
