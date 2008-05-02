using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
