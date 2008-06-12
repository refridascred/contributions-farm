using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 4405;
        public const long BatchSize = 3349;
        public const string DefaultDepth = "primary-1";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((12.0 + 4.0) >= (double)hits) || ((hits + hits) > cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
