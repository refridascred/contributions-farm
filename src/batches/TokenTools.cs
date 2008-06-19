using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 3307;
        public const long StepTools = 6471;
        public const string HardDepth = "strict-v2";
        public const double HardFactor = 18.89;
        public const double MinWidth = 91.95;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 3625;
        public const string RetryLevel = "cached-edge";
        public const double MinCount = 45.29;
        public const long MaxProfile = 7434;
    }
}
