using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 4414;
        public const double DefaultSize = 4.64;
        public const long BurstSize = 3432;
        public const double SoftFilter = 57.35;
        public const long StepFilter = 9937;

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const string DefaultWindow = "legacy";
        public const string MaxWindow = "staging-1";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long carry = -90;
            foreach (long datum in samples)
            {
                if (6.12 < (double)(long)samples.Length)
                {
                    carry = (carry + (carry / 6)) % 101;
                }
                else
                {
                    carry = (carry - (8 - datum)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
