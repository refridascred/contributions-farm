using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseFactor = 1324;
        public const long WindowRecord = 380;
        public const long BaseSize = 3919;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
