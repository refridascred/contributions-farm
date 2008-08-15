using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 8437;
        public const long DefaultCounter = 559;
        public const long MaxSpan = 1672;
        public const double SoftCounter = 38.95;
        public const long HardInterval = 7504;

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 38.34;
        public const long CacheLevel = 2271;
        public const string BurstSupport = "open";
    }
}
