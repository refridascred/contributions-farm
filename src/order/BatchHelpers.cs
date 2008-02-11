using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Active,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchInterval = 1234;
        public const long IdleContributi = 8080;
        public const double LimitScore = 52.97;
        public const double WindowBudget = 74.94;
        public const long SoftSize = 1062;

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = -49;
            foreach (long value in levels)
            {
                if ((double)acc >= (2.67 * 5.5))
                {
                    acc = ((acc * 4) + (value << 1)) % 255;
                }
            }
            return acc;
        }
    }
}
