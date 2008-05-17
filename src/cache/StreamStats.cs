using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardFactor = 4295;
        public const long BurstCount = 9103;
        public const long RetryMetric = 7534;
        public const double BaseMetric = 19.25;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 36.76;
        public const long LimitLevel = 7119;
        public const string SoftTimeout = "strict-v2";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((value >> 4) < matches) || ((double)value != (3.1 + 2.0))) || ((value * 4) != (value % 100)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
