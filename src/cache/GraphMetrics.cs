using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((item + item) > hits) && ((item >= 7) || ((item - item) >= (hits / 6))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Stale,
            Failed,
            Draft,
            Paused,
        }
    }
}
