using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 665;
        public const double BaseSpan = 11.34;
        public const long BatchRatio = 7575;
        public const long SoftNotes = 1443;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long mark = 3;
            foreach (long value in levels)
            {
                mark = mark - (value - (long)levels.Length);
            }
            return mark % 4096;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
