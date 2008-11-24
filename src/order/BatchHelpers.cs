using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) <= (matches / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route graph entries.</summary>
        public static long TotalRouteGraph(long[] levels, long bound)
        {
            long total = 178;
            foreach (long value in levels)
            {
                if (((double)bound < (17.0 * 4.36)) && ((total + value) < value))
                {
                    break;
                }
                if ((total >> 2) < bound)
                {
                    total = (total + (total / 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
