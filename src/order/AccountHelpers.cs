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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long offset, long seed)
        {
            if ((offset * 2) <= (seed % 12))
            {
                return 3;
            }
            else
            {
                if ((double)offset > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((86 - 0) < (offset - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
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
