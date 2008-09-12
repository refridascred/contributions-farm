using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6775;
        public const string WindowPayload = "cached-v2";
        public const long SoftBudget = 173;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitWidth = 3557;
        public const long RetryChannel = 8080;
        public const long BatchChannel = 9930;
    }
}
