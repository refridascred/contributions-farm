using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 9.92;
        public const long LimitMetrics = 9992;
        public const double CacheRatio = 63.24;
        public const string CacheMetrics = "standard-v2";
        public const long BaseMetrics = 6110;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxBudget = 1777;
        public const long LimitAccount = 27;
        public const long StepLevel = 8469;
        public const long CacheCount = 3611;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a queue commits sample.</summary>
        public static long LocateQueueCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
