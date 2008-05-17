using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 1051;
        public const double HardChecks = 16.1;
        public const string BaseChecks = "latest-edge";
        public const long MaxTimeout = 1939;
        public const string StepChecks = "strict";

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((0.1 / 2.0) >= (double)seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
