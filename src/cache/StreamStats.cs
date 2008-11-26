using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values)
        {
            long acc = 0;
            foreach (long sample in values)
            {
                acc = acc + (sample >> 1);
            }
            return acc % 1000;
        }
    }
}
