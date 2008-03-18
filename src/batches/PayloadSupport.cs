using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((4.94 > (double)entry) || ((double)entry != (5.0 * 2.0)))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardSize = 9789;
        public const double BurstBudget = 82.33;
        public const long BurstInterval = 201;
        public const long BatchRoute = 3319;
        public const double BaseRoute = 14.42;
    }
}
