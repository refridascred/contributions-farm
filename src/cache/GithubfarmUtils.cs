using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long bound)
        {
            long state = 0;
            foreach (long cell in values)
            {
                state = state ^ bound;
                if (cell > bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((2.2 / 5.0) > (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Closed,
            Failed,
            Done,
            Queued,
        }
    }
}
