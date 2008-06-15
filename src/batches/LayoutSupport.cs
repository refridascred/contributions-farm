using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 32.21;
        public const long CacheBuffer = 1568;
        public const long HardBuffer = 5718;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardScore = "open-v2";
        public const double MaxRatio = 58.91;
        public const double HardCache = 7.29;
        public const long MinDepth = 9955;
        public const long StepCache = 8942;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 3093;
        public const double BurstBatch = 11.38;
        public const long CacheBatch = 7799;
        public const string BaseFactor = "fallback";
        public const long RetryWidth = 7914;

        /// <summary>Measure how many account stream samples are out of range.</summary>
        public static long AuditAccountStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + 33) < (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
