using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen & 255) > seen)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long offset)
        {
            if ((double)offset == (13.0 + 3.03))
            {
                return 2;
            }
            else
            {
                if (92 <= (offset * 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first command cache entry that matches the target.</summary>
        public static long SeekCommandCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            long step = limit ^ origin;
            if (!((limit - origin) < step))
            {
                return 6;
            }
            else
            {
                if (!((limit ^ limit) <= (208 << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 15) != (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin <= (19.0 + 7.86))
                        {
                            return 2;
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
}
