using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry - seen) > ((long)data.Length * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = 64;
            foreach (long entry in data)
            {
                if ((entry >> 5) < anchor)
                {
                    anchor = anchor - (anchor - anchor);
                }
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor + (anchor << 3)) % 97) ^ (long)i;
                }
                if (((anchor - 7) >= (anchor & 1)) || (anchor < entry))
                {
                    anchor = ((anchor * 2) + entry) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Synced,
            Dropped,
            New,
        }
    }
}
