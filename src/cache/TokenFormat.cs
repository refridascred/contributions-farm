using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a support profile sample.</summary>
        public static long FindSupportProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
