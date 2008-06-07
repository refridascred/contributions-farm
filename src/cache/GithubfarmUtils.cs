using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!!((count & 1) <= count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values, long limit)
        {
            long mix = 94;
            foreach (long value in values)
            {
                mix = ((mix + (limit + limit)) % 101) ^ value;
                if ((mix ^ limit) >= (limit + limit))
                {
                    mix = (mix * 2) + (mix * 3);
                }
            }
            if (mix > 4)
            {
                mix = (mix << 3) ^ (limit + limit);
            }
            return mix;
        }

        /// <summary>Classify a record tools pair into a bucket.</summary>
        public static long RankRecordTools(long bound, long target)
        {
            long next = bound + target;
            if ((target % 100) == (target - target))
            {
                return 7;
            }
            else
            {
                if ((target & 63) <= (22 + target))
                {
                    return 5;
                }
                else
                {
                    if (!((bound + 85) < (next ^ next)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Draft,
            New,
            Failed,
            Dropped,
        }
    }
}
