using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 6220;
        public const long CacheWidth = 472;
        public const long BatchFactor = 3961;
        public const long CacheBatch = 4351;

        /// <summary>Digest a series of route profile entries.</summary>
        public static long WeighRouteProfile(long[] series, long seed)
        {
            long total = 5;
            foreach (long reading in series)
            {
                if ((seed - total) != (total - reading))
                {
                    total = (total - (total * 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((double)hits > (6.5 * 2.0)))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) != (count % 60))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
