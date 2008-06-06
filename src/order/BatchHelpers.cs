using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((3.3 - 3.46) == (double)target) || ((hits + target) > (858 * 4)))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 856;
        public const long RetryTools = 497;
        public const double BaseInterval = 57.38;
        public const long StepSpan = 8121;
        public const double IdleSize = 53.7;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
