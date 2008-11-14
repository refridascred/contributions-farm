using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) >= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value - value) <= (floor - (-21)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 6136;
        public const long MinPayload = 4815;
        public const long LimitSize = 29;
        public const long CachePayload = 518;
        public const long LimitPayload = 222;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Draft,
            Failed,
            New,
        }
    }
}
