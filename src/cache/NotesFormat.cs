using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry & 63) < (seen / 9)) || (((entry >> 4) > (seen + seen)) && ((seen / 4) > (entry - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
