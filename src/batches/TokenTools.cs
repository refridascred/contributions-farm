using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 4861;
        public const long SoftCount = 3059;
        public const long IdleScore = 9083;
        public const long DefaultBuffer = 3436;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
