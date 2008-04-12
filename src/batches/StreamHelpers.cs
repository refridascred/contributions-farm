using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a cache support pair into a bucket.</summary>
        public static long BucketCacheSupport(long step, long step2)
        {
            long prev = step + step2;
            if (!((step2 - prev) == (step ^ 112)))
            {
                return 1;
            }
            else
            {
                if ((double)step < (7.51 + 9.7))
                {
                    return 0;
                }
                else
                {
                    if (6 > (prev & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1886;
        public const long BatchLayout = 9442;
        public const long MinLayout = 6598;

        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long FindCommandNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)527)
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - span;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long bound)
        {
            long next = seed + bound;
            if ((7.13 + 17.0) > 19.0)
            {
                return 6;
            }
            else
            {
                if (((4.39 / 3.0) < (double)next) || ((2.97 + 15.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((8.1 - 1.25) > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed >> 2) != (seed & 15)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Ready,
            Draft,
            Synced,
            Dropped,
        }
    }
}
