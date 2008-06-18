using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultScore = 6617;
        public const long BatchSize = 3031;
        public const long RetryRatio = 2916;
        public const long IdleFactor = 1067;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen % 7) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
