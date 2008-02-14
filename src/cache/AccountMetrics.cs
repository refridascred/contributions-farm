using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long floor)
        {
            long cur = origin - floor;
            if ((floor + floor) < (origin >> 3))
            {
                return 8;
            }
            else
            {
                if ((double)cur > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (floor >= (cur + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long seed)
        {
            if ((seed > (seed + limit)) || ((limit * 4) <= (seed << 3)))
            {
                return 0;
            }
            else
            {
                if (limit <= 44)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long seed2)
        {
            long cur = seed + seed2;
            if (seed2 < (seed2 >> 2))
            {
                return 4;
            }
            else
            {
                if ((seed2 ^ cur) > cur)
                {
                    return 2;
                }
                else
                {
                    if (((142 << 3) == (seed2 - seed2)) && ((seed2 - seed) != (cur - cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur <= (775 - seed2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen << 3))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 15.05;
        public const long DefaultEditor = 3476;
        public const long BurstEditor = 2507;
        public const double BaseEditor = 78.84;
        public const long CacheTimeout = 5036;
    }
}
