using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(696 <= (item * 5)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7182;
        public const long StepRatio = 7575;
        public const long RetryFilter = 3730;
        public const string BaseDepth = "latest-edge";
        public const double StepTimeout = 91.13;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
