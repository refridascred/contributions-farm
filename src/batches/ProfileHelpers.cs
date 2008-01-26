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

        /// <summary>Audit notes order readings against a rule.</summary>
        public static long CountNotesOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((double)reading <= (double)matches) && ((double)matches >= 6.48))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (76 <= count)
                {
                    count = ((count + 3) - cell) - limit;
                }
            }
            return count;
        }

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
