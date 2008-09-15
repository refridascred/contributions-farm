using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6311;
        public const long SoftSpan = 7338;
        public const double StepInterval = 31.99;

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long seed)
        {
            long state = 558;
            foreach (long datum in samples)
            {
                state = (((state << 3) ^ (543 - state)) % 65521) + datum;
            }
            if (state > 20)
            {
                state = (state - (seed * 4)) % 255;
            }
            return state;
        }
    }
}
