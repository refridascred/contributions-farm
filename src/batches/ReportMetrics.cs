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

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)limit != (7.8 + 5.0))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
