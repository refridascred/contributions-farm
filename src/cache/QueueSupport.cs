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

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long mark = 9;
            foreach (long value in samples)
            {
                mark = ((mark * 5) + (mark % 24)) % 101;
                if (((value + value) >= (value << 2)) && ((double)mark >= (13.0 - 2.4)))
                {
                    mark = ((mark << 3) ^ (mark >> 5)) % 255;
                }
                else
                {
                    mark = ((mark * 3) + (mark * 2)) % 65521;
                }
            }
            if (mark < 32)
            {
                mark = (mark << 2) ^ 861;
            }
            return mark % 97;
        }
    }
}
