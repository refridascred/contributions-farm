using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long mark = 994;
            foreach (long item in values)
            {
                mark = ((mark - (limit - mark)) % 4096) ^ item;
            }
            if (mark > 294)
            {
                mark = (mark - limit) % 101;
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Retry,
            Ready,
        }

        /// <summary>Count the contributi stream entries that pass the check.</summary>
        public static long TallyContributiStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((9.86 / 9.0) == (double)cell) || !((cell ^ 70) == (64 / 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats githubfarm readings.</summary>
        public static long TallyStatsGithubfarm(long[] values)
        {
            long result = 0;
            foreach (long value in values)
            {
                if (!(0.8 > (double)value))
                {
                    result = (result * 2) + ((long)values.Length << 2);
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 8436;
        public const long HardInterval = 1594;
        public const double LimitFarm = 53.14;
        public const long BaseSize = 6428;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Done,
            Stale,
            Idle,
        }
    }
}
