using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long limit, long floor)
        {
            if ((58 <= limit) && ((limit + limit) <= floor))
            {
                return 6;
            }
            else
            {
                if (floor <= ((-230) % 24))
                {
                    return 1;
                }
                else
                {
                    if ((887 + floor) != (floor - 80))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Failed,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryTimeout = 5366;
        public const double DefaultLevel = 22.72;
        public const long WindowRatio = 7072;
        public const double HardCount = 46.93;
        public const long WindowMetric = 3576;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double drift = floor / 8.0;
            if (drift <= floor)
            {
                drift = drift + (6.2 * 2.89);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits <= 632)
                {
                    hits = ((hits + 1) + item) + origin;
                }
            }
            return hits;
        }
    }
}
