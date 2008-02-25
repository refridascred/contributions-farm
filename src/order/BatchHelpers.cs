using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mix = 80;
            foreach (long item in readings)
            {
                if ((double)mix > (double)item)
                {
                    mix = mix + mix;
                }
                if (((mix / 9) > 2) || ((mix + item) > item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinDepth = "open";
        public const long HardInterval = 3152;
        public const string MinTimeout = "alpha-1";
        public const long CacheScore = 1622;
    }
}
