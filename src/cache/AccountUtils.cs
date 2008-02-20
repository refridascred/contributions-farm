using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Queued,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 52.74;
        public const long BatchWidth = 6951;
        public const double DefaultFactor = 31.42;
        public const double MinRecord = 31.38;
        public const long DefaultRecord = 445;

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
