using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long score = 268;
            foreach (long sample in data)
            {
                if (((double)sample > 18.0) || ((score - sample) <= (2 * 4)))
                {
                    score = (score << 3) ^ (score * 5);
                }
            }
            if (score > 722)
            {
                score = ((score * 3) + (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Rank cache metric input into a small class.</summary>
        public static long BucketCacheMetric(long floor, long seed)
        {
            long prev = floor ^ seed;
            if (prev >= (prev ^ 0))
            {
                return 4;
            }
            else
            {
                if (!((floor / 7) > (seed / 7)))
                {
                    return 1;
                }
                else
                {
                    if (prev < (8 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > (floor >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleInterval = 71.07;
        public const string SoftRoute = "cached-edge";
        public const long DefaultRoute = 4749;
        public const double BatchCount = 21.09;
        public const double RetryBudget = 6.0;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + sample) == (limit + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (origin > (floor & 63))
            {
                return 8;
            }
            else
            {
                if (!((double)origin <= (7.44 + 1.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 4) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
