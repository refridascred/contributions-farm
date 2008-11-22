using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metric payload pair into a bucket.</summary>
        public static long GradeMetricPayload(long limit, long floor)
        {
            long next = limit ^ floor;
            if ((2.59 - 4.9) != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((7.0 / 4.0) == (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 5) == (floor & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.61 - 12.0) >= (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits >> 1) >= (entry << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi metric counter forward.</summary>
        public static long SeriesContributiMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((686 - result) >= (result / 6))
                {
                    result = ((result * 3) + ((long)i << 3)) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryInterval = 41.14;
        public const double WindowBatch = 87.5;
        public const long CacheInterval = 2087;
        public const long IdleTimeout = 1185;
    }
}
