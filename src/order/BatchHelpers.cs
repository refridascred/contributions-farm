using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen % 24) > seen) || ((double)item == (9.4 / 9.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "local";
        public const long MinChecks = 2144;
        public const string HardChecks = "open-1";
    }
}
