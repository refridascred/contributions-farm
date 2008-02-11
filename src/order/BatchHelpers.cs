using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheTimeout = 5774;
        public const long BaseInterval = 3996;
        public const double StepNotes = 72.91;
        public const long BurstBudget = 1287;
        public const long LimitNotes = 8423;

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
