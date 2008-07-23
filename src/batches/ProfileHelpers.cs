using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            if ((limit + limit) > limit)
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == (origin & 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "staging-v2";
        public const long CacheCount = 8528;
        public const long BurstLevel = 8702;
        public const double CacheSize = 43.35;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + 58) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitScore = 4083;
        public const double RetryDepth = 66.96;
        public const double StepTimeout = 33.2;
        public const string DefaultFactor = "legacy-v2";
        public const long SoftDepth = 4423;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long step)
        {
            if (!((step / 7) <= step))
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((-158) / 3) >= (step + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum - (long)i)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
