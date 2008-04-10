using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Combine batches graph values into a single score.</summary>
        public static long DigestBatchesGraph(long[] values)
        {
            long mark = 74;
            foreach (long datum in values)
            {
                mark = ((mark << 2) ^ 4) % 255;
                mark = mark + (datum % 97);
            }
            if (mark < 68)
            {
                mark = (mark + (mark + 365)) % 255;
            }
            return mark;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((tally + tally) > (tally ^ limit)))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            long offset = limit - target;
            if (target <= offset)
            {
                return 5;
            }
            else
            {
                if (limit <= offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
