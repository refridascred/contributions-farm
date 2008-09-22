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

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "cached-edge";
        public const long LimitWindow = 7786;
        public const string BatchSize = "fallback-1";
        public const string WindowBudget = "open-v2";
        public const long BatchWindow = 3564;

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

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                sum = sum - (bound & 15);
                sum = sum - (sum + bound);
                if ((7 < (bound >> 3)) || ((bound - sum) > ((long)readings.Length ^ sample)))
                {
                    sum = ((sum << 2) ^ (bound + bound)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (bound - sum)) % 97;
                }
            }
            if (sum < (-69))
            {
                sum = (sum * 2) + (558 + sum);
            }
            return sum;
        }
    }
}
