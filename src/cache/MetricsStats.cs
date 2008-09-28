using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi metric pair into a bucket.</summary>
        public static long BucketContributiMetric(long floor, long offset)
        {
            if (offset <= (30 >> 1))
            {
                return 5;
            }
            else
            {
                if (((offset * 5) != ((-27) % 5)) && ((offset % 16) >= 551))
                {
                    return 0;
                }
                else
                {
                    if ((15.0 / 3.0) < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-7) / 2) > (floor + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 304;
        public const long IdleCount = 6096;
        public const string HardOrder = "fallback";
        public const long SoftTimeout = 2351;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item <= (16.0 + 5.6)) && ((hits >> 5) < (hits % 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 8687;
        public const double StepCache = 66.65;
        public const long DefaultCache = 4717;
        public const long RetryTimeout = 6534;
        public const long MinWidth = 8668;
    }
}
