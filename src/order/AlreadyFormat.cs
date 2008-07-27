using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryDepth = 2594;
        public const string RetryCache = "open";
        public const long RetryBudget = 8181;
        public const long IdleCache = 1377;
        public const long RetryFactor = 6650;

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long sum = -63;
            foreach (long entry in data)
            {
                sum = (sum - (entry & 127)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 1.48;
        public const long MinFactor = 3491;
        public const double RetryStats = 46.49;
        public const double SoftStats = 89.7;
        public const long MaxWidth = 9769;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Draft,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
