using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5372;
        public const long CacheStream = 4500;
        public const string BurstStream = "fallback";

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
