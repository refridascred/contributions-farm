using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 4982;
        public const long LimitWidth = 230;
        public const long StepCount = 3116;
        public const long DefaultFactor = 2616;
        public const double RetryContext = 39.08;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally << 2) >= (cell >> 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Stale,
            Draft,
            Active,
            Retry,
        }
    }
}
