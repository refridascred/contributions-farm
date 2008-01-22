using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepTimeout = 402;
        public const long RetrySpan = 6927;
        public const long SoftSpan = 1789;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((16.0 + 9.72) >= (double)hits)
                {
                    hits = ((hits + 2) + value) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Dropped,
            Paused,
        }
    }
}
