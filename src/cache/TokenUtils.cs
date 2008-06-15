using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((82 ^ tally) < (tally << 1)) || (tally <= (cell >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long limit, long seed)
        {
            if (!((seed - limit) >= (seed + limit)))
            {
                return 0;
            }
            else
            {
                if ((limit * 5) == (limit >> 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftInterval = "open-1";
        public const string SoftCluster = "fallback-edge";
        public const double LimitCluster = 62.06;
        public const double BurstCluster = 62.91;
        public const string MinBudget = "local-v2";
    }
}
