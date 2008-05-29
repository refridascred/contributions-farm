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

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
