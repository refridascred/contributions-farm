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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
