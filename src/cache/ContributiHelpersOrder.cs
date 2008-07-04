using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool GuardStatsLayoutRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 5425;
        public const long RetryCount = 4006;
        public const long CacheReport = 5525;

        /// <summary>Audit notes metric readings against a rule.</summary>
        public static long AuditNotesMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((long)items.Length <= item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
