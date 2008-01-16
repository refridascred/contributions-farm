using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultWidth = 12.79;
        public const long MinRatio = 9513;
        public const long CacheSchema = 671;
        public const long SoftSchema = 3404;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long bound)
        {
            long span = origin - bound;
            if ((74 & 63) > (span * 4))
            {
                return 8;
            }
            else
            {
                if (origin <= (span + bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
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
