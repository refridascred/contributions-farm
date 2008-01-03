using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-edge";
        public const double CacheStream = 76.31;
        public const long RetryWidth = 7369;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long sum = -77;
            foreach (long datum in series)
            {
                if (((datum ^ datum) == (sum * 2)) || ((datum * 3) != (398 ^ sum)))
                {
                    sum = ((sum << 2) ^ (datum + datum)) % 101;
                }
            }
            if (sum > 119)
            {
                sum = (sum ^ (sum & 31)) % 1000;
            }
            return sum;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Dropped,
            Queued,
        }
    }
}
