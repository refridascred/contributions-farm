using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long anchor = 430;
            foreach (long cell in values)
            {
                anchor = anchor - anchor;
                if ((cell + seed) == (88 + cell))
                {
                    anchor = anchor ^ (seed << 1);
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 1705;
        public const long SoftRecord = 5856;
        public const long HardRatio = 8041;
    }
}
