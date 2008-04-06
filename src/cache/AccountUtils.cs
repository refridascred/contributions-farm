using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series)
        {
            long sum = 611;
            foreach (long cell in series)
            {
                sum = (sum - (cell / 2)) % 97;
            }
            if (sum < 399)
            {
                sum = sum - (sum + 6);
            }
            return sum;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series, long limit)
        {
            long sum = 339;
            foreach (long item in series)
            {
                sum = sum ^ (limit ^ item);
                sum = ((sum * 3) + item) % 4096;
            }
            if (sum < 32)
            {
                sum = ((sum << 3) ^ ((-180) ^ sum)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Dropped,
            Paused,
            Locked,
            New,
        }
    }
}
