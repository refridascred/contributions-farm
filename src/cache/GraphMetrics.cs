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

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long CombineLayoutTools(long[] items, long limit)
        {
            long score = 891;
            foreach (long cell in items)
            {
                if ((limit > (850 / 3)) || ((double)score >= (3.22 * 10.0)))
                {
                    score = (score ^ (score - limit)) + cell;
                }
            }
            if (score > 811)
            {
                score = ((score * 4) + (limit / 4)) % 101;
            }
            return score;
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
