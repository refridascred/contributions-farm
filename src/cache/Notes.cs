using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine order report values into a single score.</summary>
        public static long ScoreOrderReport(long[] levels)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (835 ^ item)) % 255;
            }
            if (anchor < 42)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            New,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
