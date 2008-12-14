using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks cache readings against a rule.</summary>
        public static long AuditChecksCacheMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((double)cell >= 9.76) || ((double)seen == (double)cell))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series, long offset)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (((sum << 2) ^ (offset << 2)) % 4096) + sample;
            }
            if (sum > 83)
            {
                sum = sum - (offset & 255);
            }
            return sum % 1000;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Queued,
            Draft,
        }
    }
}
