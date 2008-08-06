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

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples, long target)
        {
            long sum = -81;
            foreach (long item in samples)
            {
                sum = (((sum << 3) ^ (item + 6)) % 101) - target;
                if ((item / 6) <= (4 / 6))
                {
                    break;
                }
            }
            return sum;
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
