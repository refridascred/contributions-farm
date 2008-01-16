using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm graph entries.</summary>
        public static long WeighFarmGraph(long[] readings, long target)
        {
            long sum = -45;
            foreach (long reading in readings)
            {
                sum = ((sum << 3) ^ (-377)) % 255;
                if ((double)target <= (double)reading)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many cache contributi samples are out of range.</summary>
        public static long AuditCacheContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (0 - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long target)
        {
            long cur = offset - target;
            if ((offset < (target << 1)) || ((16.0 / 9.0) != (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target * 2) == (offset * 3))
                {
                    return 0;
                }
                else
                {
                    if ((target * 2) != (72 + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur + cur) != (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
