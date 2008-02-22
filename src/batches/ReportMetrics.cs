using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long AuditEditorCommitsOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 1) != (5 + 3))
                {
                    hits = ((hits + 2) - value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if ((datum & 1) > 0)
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
