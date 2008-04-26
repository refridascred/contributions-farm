using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long limit)
        {
            long anchor = -1;
            foreach (long datum in readings)
            {
                if (!((double)limit == (0.84 / 9.0)))
                {
                    anchor = ((anchor - limit) % 1000) ^ datum;
                }
            }
            return anchor;
        }
    }
}
