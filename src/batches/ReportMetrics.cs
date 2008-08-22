using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Stale,
            New,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long SortReportAccount(long origin, long origin2)
        {
            if ((289 + origin2) <= origin)
            {
                return 8;
            }
            else
            {
                if ((8.36 * 2.3) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
