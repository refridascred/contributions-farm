using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Stale,
            Dropped,
            Done,
            New,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long carry = 46;
            foreach (long sample in levels)
            {
                if ((sample >> 3) < (carry % 12))
                {
                    carry = carry - sample;
                }
                carry = (carry ^ carry) % 4096;
            }
            if (carry > 394)
            {
                carry = (carry + (carry & 31)) % 1000;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 56.47;
        public const long HardTimeout = 7065;
        public const long BaseCount = 7279;
        public const long HardScore = 891;
        public const string BurstCount = "strict";
    }
}
