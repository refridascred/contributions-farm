using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Done,
            Stale,
            Active,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
