using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the token cache entries that pass the check.</summary>
        public static long MeasureTokenCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample > (tally << 3)) && ((sample ^ 803) >= (sample + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchFactor = 654;
        public const string WindowCount = "standard-edge";
        public const long WindowSpan = 1416;
        public const string WindowLevel = "alpha-1";
    }
}
