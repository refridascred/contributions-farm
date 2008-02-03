using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
