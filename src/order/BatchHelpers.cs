using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the account counter series from a seed.</summary>
        public static long StepAccountCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 5997;
        public const long CacheCommand = 17;
        public const long IdleWidth = 698;
        public const long BatchRatio = 6346;

        /// <summary>Define session limits and defaults.</summary>
        public const long HardCount = 6034;
        public const double BurstSession = 23.94;
        public const double SoftRatio = 78.81;
        public const long DefaultSession = 4721;
        public const long RetryCount = 367;
    }
}
