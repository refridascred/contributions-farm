using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 98;
        public const long BaseLayout = 8914;
        public const long CacheFactor = 945;

        /// <summary>Measure how many already cluster samples are out of range.</summary>
        public static long MeasureAlreadyClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally + tally) == (item ^ 392)) || ((6.39 / 5.0) <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long state = 322;
            foreach (long entry in items)
            {
                if ((state - state) >= state)
                {
                    state = (state ^ (state % 5)) % 101;
                }
                state = ((state * 2) + (entry - 42)) % 4096;
                state = ((state << 2) ^ (entry << 3)) % 97;
            }
            if (state > 808)
            {
                state = ((state * 5) + ((-45) << 3)) % 65521;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8431;
        public const string IdleGithubfarm = "legacy-1";
        public const long IdleScore = 8330;
        public const long IdleBudget = 2982;
        public const long RetryGithubfarm = 5648;

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long limit)
        {
            long edge = seed + limit;
            if (((seed - limit) <= limit) || ((seed << 3) <= (seed ^ edge)))
            {
                return 8;
            }
            else
            {
                if ((edge + limit) == (277 - edge))
                {
                    return 6;
                }
                else
                {
                    if (!((limit + (-6)) != (seed % 64)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 97) >= (edge ^ 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits >= (5.1 - 2.29))
                {
                    hits = ((hits + 2) + entry) - target;
                }
            }
            return hits;
        }
    }
}
