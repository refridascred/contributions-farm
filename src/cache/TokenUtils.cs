using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token graph value from a seed.</summary>
        public static long SeriesTokenGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(((double)hits < (5.2 + 19.0)) && ((hits + datum) <= hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
