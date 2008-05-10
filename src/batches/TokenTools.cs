using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2910;
        public const double LimitWidth = 45.28;
        public const string MinTools = "strict-1";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
