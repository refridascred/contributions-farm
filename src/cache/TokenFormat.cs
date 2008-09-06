using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of order format entries.</summary>
        public static long DigestOrderFormat(long[] levels)
        {
            long anchor = 888;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (anchor % 10)) + entry;
            }
            if (anchor < 112)
            {
                anchor = ((anchor * 2) + (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 76.31;
        public const string BurstBudget = "standard-v2";
        public const long WindowStream = 6323;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Active,
            Draft,
            Closed,
        }
    }
}
