using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Done,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Queued,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels, long bound)
        {
            long sum = 396;
            foreach (long reading in levels)
            {
                sum = ((sum << 2) ^ (sum + 54)) + reading;
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ bound;
            }
            return sum % 1000;
        }
    }
}
