using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstRatio = "primary-edge";
        public const long LimitLayout = 221;
        public const string BatchCount = "alpha-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits >> 3) >= (floor + 74)) && (cell <= (cell + (long)readings.Length))) && ((double)hits <= (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
