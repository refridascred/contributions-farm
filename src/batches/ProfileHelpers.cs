using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                mark = (mark * 4) + entry;
            }
            if (mark < 4)
            {
                mark = (mark - (0 - mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long offset)
        {
            if (((offset + offset) < 68) && (target > (4 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (13.0 * 8.0))
                {
                    return 8;
                }
                else
                {
                    if (offset > 9)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell << 2) == (4 * 3)) || ((cell ^ (-879)) > (209 ^ cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool GuardFilterGraphLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstLevel = "standard-v2";
        public const long RetryStats = 7127;
        public const long BaseRatio = 6967;
        public const long MaxCount = 2772;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
