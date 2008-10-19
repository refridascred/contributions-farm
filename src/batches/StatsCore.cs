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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
