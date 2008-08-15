using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "latest-1";
        public const long IdleRecord = 4706;
        public const double HardRecord = 61.91;
        public const string DefaultRatio = "latest-1";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftCount = 7384;
        public const double LimitDepth = 75.94;
        public const long StepDepth = 6556;
        public const long MinBudget = 7021;
        public const string BurstBudget = "latest-v2";
    }
}
