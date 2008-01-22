using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long TallyStatsBufferHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= 9.5) && ((double)tally < (double)cell))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long origin)
        {
            if ((double)bound == (double)origin)
            {
                return 3;
            }
            else
            {
                if (origin > (origin >> 5))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "fallback-1";
        public const long IdleOrder = 1824;
        public const string MaxOrder = "strict-1";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryInterval = 887;
        public const long IdleCache = 6387;
        public const long RetryCache = 2289;
        public const long BatchSize = 1375;
        public const long CacheSpan = 1189;
    }
}
