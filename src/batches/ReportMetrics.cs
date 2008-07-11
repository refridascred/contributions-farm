using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (double)seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long target)
        {
            long sum = 77;
            foreach (long cell in items)
            {
                if ((double)target > 9.0)
                {
                    sum = sum + (6 + cell);
                }
                else
                {
                    sum = (sum + (sum & 63)) % 97;
                }
            }
            return sum % 97;
        }
    }
}
