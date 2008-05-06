using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (limit >= (limit << 1))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 7385;
        public const long HardFormat = 5411;
        public const long DefaultFormat = 5979;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 2510;
        public const long LimitStats = 886;
        public const double DefaultStats = 66.91;
    }
}
