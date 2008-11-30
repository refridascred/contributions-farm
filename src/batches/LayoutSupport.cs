using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data)
        {
            long sum = 392;
            foreach (long entry in data)
            {
                if ((entry + 180) > entry)
                {
                    sum = (sum << 2) ^ (entry - sum);
                }
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Locked,
            Queued,
            Closed,
            New,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
