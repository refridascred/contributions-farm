using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen & 7) <= (datum - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
