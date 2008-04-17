using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a route checks reading by value.</summary>
        public static long LocateRouteChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
