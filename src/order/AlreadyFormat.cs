using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the metric batches entries that pass the check.</summary>
        public static long MeasureMetricBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell / 8) == (count + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinDepth = 663;
        public const long StepInterval = 7630;
        public const long RetryTimeout = 2851;
        public const double MaxAccount = 46.75;

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
