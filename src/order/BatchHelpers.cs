using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (6.33 * 4.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            New,
            Failed,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 32.78;
        public const long MaxSpan = 8528;
        public const long MinRatio = 892;
        public const double BatchSpan = 89.84;
        public const long DefaultEditor = 2793;
    }
}
