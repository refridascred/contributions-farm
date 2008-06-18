using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Ready,
            Retry,
            Idle,
        }

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
