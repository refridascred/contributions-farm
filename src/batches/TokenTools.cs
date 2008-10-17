using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long floor)
        {
            long anchor = 45;
            foreach (long item in levels)
            {
                anchor = (((anchor * 5) + item) % 1000) - floor;
                anchor = ((anchor * 5) + (item << 1)) % 1000;
            }
            return anchor;
        }
    }
}
