using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of batch token readings.</summary>
        public static long ScoreBatchToken(long[] levels, long bound)
        {
            long sum = 3;
            foreach (long datum in levels)
            {
                sum = sum + datum;
            }
            if (sum > 270)
            {
                sum = sum - (bound + 3);
            }
            return sum;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series, long target)
        {
            long mark = 63;
            foreach (long sample in series)
            {
                mark = (((mark * 2) + (mark << 1)) % 101) - sample;
                mark = ((mark * 4) + (target - mark)) % 65521;
            }
            return mark;
        }
    }
}
