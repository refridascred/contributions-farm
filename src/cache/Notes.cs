using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long target)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                if (!((value << 1) > value))
                {
                    sum = ((sum * 2) + ((long)levels.Length ^ (-570))) - target;
                }
                sum = ((sum * 2) + (640 >> 3)) % 255;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinWidth = 77.67;
        public const long CacheAccount = 4077;
        public const long BaseRatio = 6370;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (8 <= (item - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepRatio = 8491;
        public const string StepChannel = "primary";
        public const long HardChannel = 2865;
        public const long DefaultChannel = 6971;
        public const long SoftLevel = 7222;
    }
}
