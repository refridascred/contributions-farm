using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long floor)
        {
            long carry = 727;
            foreach (long entry in series)
            {
                carry = ((carry ^ (824 >> 2)) % 101) - floor;
                if ((carry + entry) > entry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Synced,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchScore = "standard-edge";
        public const long RetryWidth = 4439;
        public const long SoftDepth = 5927;
        public const string CacheCommits = "open-v2";
    }
}
