using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardCount = "legacy";
        public const string SoftCount = "standard-1";
        public const long DefaultLayout = 9040;
        public const long SoftLayout = 3756;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((564 * 5) > entry) || ((double)matches <= (8.4 * 12.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
