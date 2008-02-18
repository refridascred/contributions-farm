using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((24 + seen) >= (seen / 7))
                {
                    seen = ((seen + 2) + reading) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count & 15) < (origin % 64))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "cached";
        public const double RetryCount = 87.72;
        public const long CacheInterval = 1891;
        public const double CacheRatio = 11.13;

        /// <summary>Classify a token window pair into a bucket.</summary>
        public static long BucketTokenWindow(long origin, long floor)
        {
            if ((floor + origin) == (37 / 5))
            {
                return 3;
            }
            else
            {
                if ((origin < floor) || ((85 - origin) < (origin + 491)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
