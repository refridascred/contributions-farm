using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinRatio = 815;
        public const double WindowDepth = 84.27;
        public const string WindowSupport = "stable-1";
        public const long SoftSupport = 5922;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long MeasureSessionStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen & 3) <= (22 - seen)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
