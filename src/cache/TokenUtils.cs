using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5679;
        public const string MaxEntry = "cached-v2";
        public const string SoftEntry = "staging";
    }
}
