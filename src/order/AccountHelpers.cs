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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Grade a account counter value against two limits.</summary>
        public static long BucketAccountCounter(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((delta + bound) >= bound)
            {
                return 4;
            }
            else
            {
                if (bound2 <= delta)
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound2) > (bound2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 >= (bound2 - 44)) && ((double)bound <= (6.01 * 7.1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 26.35;
        public const long LimitReport = 3745;
        public const long MaxBudget = 7052;
        public const double MaxReport = 22.2;

        /// <summary>Validate order metrics readings against a bound.</summary>
        public static bool GuardOrderMetricsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
