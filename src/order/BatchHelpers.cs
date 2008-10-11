using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch context readings against a rule.</summary>
        public static long TallyBatchContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)entry <= 20.0) && (((-2) + entry) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
