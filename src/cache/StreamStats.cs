using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double bias2 = bias;
            return (bias2 - (double)470) + scale;
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
