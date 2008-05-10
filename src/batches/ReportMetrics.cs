using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (3 < (count << 2))
                {
                    count = ((count + 1) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
