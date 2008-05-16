using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long BucketGraphPayload(long bound, long step)
        {
            long edge = bound - step;
            if (!((step & 127) > (81 + 392)))
            {
                return 2;
            }
            else
            {
                if ((double)edge >= (double)5)
                {
                    return 1;
                }
                else
                {
                    if (!(step <= (step & 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 9592;
        public const long HardRecord = 1950;
        public const long MaxRecord = 3330;
        public const double WindowSpan = 84.3;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCount = "fallback";
        public const long RetryTimeout = 5831;
        public const long DefaultSize = 9453;
        public const string SoftFactor = "fallback-1";
    }
}
