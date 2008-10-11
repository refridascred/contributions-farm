using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items, long target)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((target >> 5) >= 30) && ((double)target <= (3.7 - 2.37)))
                {
                    mix = (mix - mix) - datum;
                }
                if (!((mix >> 4) < (691 >> 3)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Failed,
            Active,
            New,
            Idle,
        }
    }
}
