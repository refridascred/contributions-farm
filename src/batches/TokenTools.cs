using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)matches > (0.6 - 3.65)) || ((double)matches >= (7.7 - 0.7)))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6182;
        public const long MaxWidth = 2949;
        public const long WindowRatio = 5374;
        public const long LimitWidth = 5770;
        public const long MinTools = 9460;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
