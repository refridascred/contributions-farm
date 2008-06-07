using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits % 24) >= (hits * 2)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >> 1) == (bound << 2))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
