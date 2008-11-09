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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum ^ (9 + sum)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleDepth = 835;
        public const long MinTimeout = 5899;
        public const long WindowOrder = 8569;
    }
}
