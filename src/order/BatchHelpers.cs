using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((step + offset) > bound)
            {
                return 6;
            }
            else
            {
                if ((3 << 2) >= (step << 2))
                {
                    return 8;
                }
                else
                {
                    if (!((bound - step) < (81 & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits < (sample + hits)) || ((4.6 * 11.0) >= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((seed + hits) == (item + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
