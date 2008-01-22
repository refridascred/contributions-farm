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

        /// <summary>Validate cache batches readings against a bound.</summary>
        public static bool ValidateCacheBatchesLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitCount = 31.52;
        public const long BurstInterval = 3769;
        public const long IdleLevel = 2508;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 792;
        public const double MinTimeout = 10.75;
        public const long RetryFactor = 9507;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryInterval = 887;
        public const long IdleCache = 6387;
        public const long RetryCache = 2289;
        public const long BatchSize = 1375;
        public const long CacheSpan = 1189;
    }
}
