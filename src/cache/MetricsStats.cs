using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((step + value) > ((long)readings.Length - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2459;
        public const string HardCounter = "staging-v2";
        public const string BaseCounter = "latest";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long limit)
        {
            long cur = offset + limit;
            if (offset > (limit % 3))
            {
                return 3;
            }
            else
            {
                if (((cur ^ cur) <= (limit - offset)) || ((4.6 / 8.0) == (double)cur))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a buffer metric value against two limits.</summary>
        public static long BucketBufferMetric(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((14.0 / 4.0) == (double)origin2)
            {
                return 8;
            }
            else
            {
                if (((2.2 * 3.0) < (double)origin) || ((9.0 * 5.8) != (double)diff))
                {
                    return 1;
                }
                else
                {
                    if (((origin2 + origin) <= origin) && (origin <= (diff >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((diff << 1) < diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
