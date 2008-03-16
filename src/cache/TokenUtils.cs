using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 7139;
        public const long SoftSize = 9366;
        public const long RetryScore = 9979;
    }
}
