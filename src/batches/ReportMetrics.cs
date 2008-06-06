using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 8769;
        public const long RetrySize = 141;
        public const double SoftFactor = 57.74;
        public const double IdleScore = 31.88;
        public const long IdleRatio = 9416;
    }
}
