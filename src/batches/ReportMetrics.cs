using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryWidth = 4398;
        public const long SoftCommits = 8318;
        public const double RetryCommits = 74.06;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long score = 777;
            foreach (long entry in samples)
            {
                if ((17.0 - 6.11) > (double)entry)
                {
                    score = (score << 2) ^ (score * 4);
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 6730;
        public const long HardWindow = 3552;
        public const long HardScore = 4478;
    }
}
