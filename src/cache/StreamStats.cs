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

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels)
        {
            long score = -6;
            foreach (long value in levels)
            {
                score = (score ^ (score + value)) % 65521;
            }
            return score;
        }

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
