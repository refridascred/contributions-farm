using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of metrics already readings.</summary>
        public static long WeighMetricsAlready(long[] series, long limit)
        {
            long sum = -796;
            foreach (long item in series)
            {
                sum = ((((sum * 5) + (sum & 127)) % 97) + item) + limit;
            }
            if (sum > 8)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Failed,
            Done,
            Stale,
        }
    }
}
