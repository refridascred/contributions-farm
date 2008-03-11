using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowSpan = "primary-1";
        public const long BatchScore = 1954;
        public const long LimitSize = 9732;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
