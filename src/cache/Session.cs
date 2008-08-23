using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell - 108))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) == (tally / 9))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }
    }
}
