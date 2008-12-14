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

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 20.74;
        public const long SoftSize = 6093;
        public const long BaseLevel = 4732;
        public const double BurstFactor = 15.28;
        public const double WindowSession = 26.85;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Queued,
            Draft,
        }
    }
}
