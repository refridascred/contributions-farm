using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(seed < reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric stream pair into a bucket.</summary>
        public static long BucketMetricStream(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((6.7 > (double)span) && (span <= (origin - origin2)))
            {
                return 1;
            }
            else
            {
                if ((double)origin2 == (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3808;
        public const long BatchToken = 3920;
        public const long CacheToken = 5444;
    }
}
