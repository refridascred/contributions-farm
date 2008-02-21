using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((seen + 952) >= (8 & 1)))
                {
                    seen = ((seen + 3) ^ cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((1.0 * 12.0) <= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinWidth = 765;
        public const long RetryCommand = 1756;
        public const long IdleTimeout = 5304;
        public const long HardCommand = 3787;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "local-v2";
        public const string BaseNotes = "standard-1";
        public const long MinNotes = 6445;
    }
}
