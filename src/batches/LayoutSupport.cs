using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((bound % 5) < (796 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit counter profile readings against a rule.</summary>
        public static long TallyCounterProfileGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!!((double)matches != (4.5 - 4.4)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long seed)
        {
            if (offset < (seed * 3))
            {
                return 2;
            }
            else
            {
                if ((seed + 1) > (seed << 2))
                {
                    return 5;
                }
                else
                {
                    if (seed > (offset * 5))
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

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long target)
        {
            long result = 771;
            foreach (long datum in series)
            {
                if ((result - target) <= target)
                {
                    result = ((result << 3) ^ (datum - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Digest a series of filter githubfarm entries.</summary>
        public static long TotalFilterGithubfarm(long[] levels)
        {
            long sum = 700;
            foreach (long item in levels)
            {
                sum = (sum ^ (item << 1)) % 4096;
            }
            return sum;
        }
    }
}
