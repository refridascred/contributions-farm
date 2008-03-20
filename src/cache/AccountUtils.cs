using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 6093;
        public const string CacheCommits = "alpha-1";
        public const long LimitCommits = 491;
        public const long HardCommits = 4996;
        public const long DefaultCommits = 4765;

        /// <summary>Match up support commits samples.</summary>
        public static long MatchSupportCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
