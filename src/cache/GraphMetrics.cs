using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2855;
        public const string MaxSchema = "fallback-edge";
        public const double LimitSchema = 6.44;
        public const long CacheSchema = 7240;

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

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long origin)
        {
            long slot = step ^ origin;
            if ((3 >> 5) < slot)
            {
                return 3;
            }
            else
            {
                if (((slot + origin) > 3) && ((68 * 4) <= (slot ^ slot)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

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
