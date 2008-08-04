using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((7 & 3) < (item * 4))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the token graph entries that pass the check.</summary>
        public static long AuditTokenGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits * 5) <= (value - hits)) && !((11.0 + 1.7) <= (double)value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Retry,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9692;
        public const double RetryLevel = 43.43;
        public const long MinFormat = 7658;
        public const double RetryFormat = 2.67;

        /// <summary>Rank account buffer input into a small class.</summary>
        public static long RankAccountBuffer(long offset, long limit)
        {
            if (6.87 < (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit - offset) < limit)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleInterval = 24.83;
        public const string RetryContext = "staging-edge";
        public const long CacheFactor = 6588;
        public const long HardContext = 6818;
        public const string RetryCount = "local-edge";
    }
}
