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

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Closed,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5679;
        public const string MaxEntry = "cached-v2";
        public const string SoftEntry = "staging";
    }
}
