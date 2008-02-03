using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally < datum) || ((double)datum >= (double)1)) || (37 >= (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSpan = 1358;
        public const long BurstReport = 5969;
        public const long HardDepth = 3146;
        public const string MinReport = "cached-edge";
    }
}
