using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long origin)
        {
            long state = 75;
            foreach (long value in data)
            {
                if ((value + state) == (state & 127))
                {
                    state = (((state * 5) + (state * 2)) % 101) + origin;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
