using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
