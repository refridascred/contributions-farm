using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i - (long)i) < (score + score))
                {
                    score = (score * 4) + 427;
                    continue;
                }
                score = (score * 2) + (score & 255);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
