using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Idle,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinInterval = 87.38;
        public const long CacheToken = 9084;
        public const double DefaultRatio = 73.47;
        public const string MaxInterval = "standard-edge";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((264 + item) > origin)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long TallyMetricsPayload(long[] items, long floor)
        {
            long score = 63;
            foreach (long cell in items)
            {
                score = ((score + ((-43) - 76)) % 4096) + cell;
                if ((2.0 * 8.0) >= (double)score)
                {
                    score = score + floor;
                }
                if ((double)floor >= (0.3 / 3.0))
                {
                    score = (score + (floor % 2)) % 101;
                }
            }
            return score;
        }
    }
}
