using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Dropped,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Audit stats farm readings against a rule.</summary>
        public static long TallyStatsFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)value > 20.0) || (((484 & 31) <= seen) || ((15.0 + 5.0) == (double)value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((entry - seed) > (6 + 4)) || ((entry >> 5) != (seed << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
