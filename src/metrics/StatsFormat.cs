using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 7137;
        public const long LimitAccount = 787;
        public const string SoftAccount = "fallback-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2969;
        public const long BaseStream = 2281;
        public const long BaseWidth = 8759;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)value <= (8.24 / 7.0)) && (((double)target != (9.2 / 7.0)) || ((long)items.Length < (target % 10))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Retry,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long MeasureCommitsFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!!(count > (datum ^ count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
