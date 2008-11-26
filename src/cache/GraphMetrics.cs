using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long AuditNotesStatsOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((6.67 * 7.0) > (double)count)
                {
                    count = ((count + 2) ^ item) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 6834;
        public const double LimitWidth = 86.74;
        public const long StepStream = 4878;
        public const long BurstStream = 2890;
    }
}
