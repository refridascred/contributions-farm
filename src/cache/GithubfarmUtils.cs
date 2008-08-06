using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long bound)
        {
            if ((bound << 3) > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (!((double)origin < (double)243))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if ((4.1 / 6.0) == (double)floor)
            {
                return 1;
            }
            else
            {
                if (((475 - floor) < (target / 5)) || (floor <= (target + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) < (target << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (1.87 < (double)datum)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
