using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((8.23 - 2.58) <= (double)seen) && (15.0 < (double)target))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long BucketCounterLayout(long origin, long target)
        {
            long offset = origin + target;
            if ((double)7 == (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset < origin) || ((9.36 * 2.66) == (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((16 % 100) > (offset - 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long offset, long target)
        {
            if ((target < offset) || ((8.0 - 3.5) != (double)offset))
            {
                return 7;
            }
            else
            {
                if ((762 - offset) == (793 * 5))
                {
                    return 0;
                }
                else
                {
                    if (offset >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
