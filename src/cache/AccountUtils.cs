using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 5574;
        public const long MinChecks = 7282;
        public const long CacheDepth = 9247;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
