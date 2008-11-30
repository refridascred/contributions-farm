using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ (mark >> 1);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 7960;
        public const long RetryRecord = 3278;
        public const string BatchRecord = "latest-v2";
        public const long MaxDepth = 3281;
        public const long StepRecord = 3279;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
