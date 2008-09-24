using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4223;
        public const double BaseChecks = 50.35;
        public const long StepChecks = 5358;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ 320) >= (reading + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
