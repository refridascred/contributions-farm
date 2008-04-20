using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Stale,
            Idle,
            New,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7877;
        public const string LimitCluster = "strict-v2";
        public const long WindowCluster = 1164;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading - reading) >= (hits - reading)) && ((6.7 - 13.0) < (double)(long)levels.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
