using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples, long seed)
        {
            long state = 6;
            foreach (long datum in samples)
            {
                state = (state + (datum + state)) + seed;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowSize = 43.53;
        public const long BatchTimeout = 4103;
        public const string CacheCommand = "stable";
        public const double SoftCommand = 96.96;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (result - result)) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
