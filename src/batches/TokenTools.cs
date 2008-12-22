using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "staging-v2";
        public const string SoftCache = "alpha";
        public const long LimitRatio = 1499;
        public const string LimitFactor = "open-v2";
        public const long WindowCache = 9518;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
