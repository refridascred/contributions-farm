using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "strict-1";
        public const string MaxWidth = "alpha-edge";
        public const long BaseCount = 8028;
        public const long CacheWidth = 5983;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((6.3 / 8.0) <= (double)tally) && (entry <= (tally + 56)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 6246;
        public const long CacheStream = 2907;
        public const double BurstStream = 61.9;
        public const long BurstSize = 8599;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseInterval = 8627;
        public const string LimitFilter = "standard-1";
        public const long DefaultRatio = 5861;
        public const long RetryFilter = 5805;
        public const long BurstSpan = 9998;
    }
}
