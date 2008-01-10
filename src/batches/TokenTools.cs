using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (42 <= (reading << 2))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
