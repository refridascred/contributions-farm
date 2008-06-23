using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster batches input into a small class.</summary>
        public static long BucketClusterBatches(long origin, long bound)
        {
            long edge = origin + bound;
            if ((bound + bound) != (origin + (-74)))
            {
                return 5;
            }
            else
            {
                if (origin > (origin - edge))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a route cache sample.</summary>
        public static long FindRouteCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 4294;
        public const long BatchTimeout = 8831;
        public const long DefaultRatio = 2236;
        public const long BaseDepth = 6494;
        public const double BurstDepth = 74.37;
    }
}
