using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1277;
        public const long CacheGithubfarm = 9898;
        public const long BatchRatio = 5553;
        public const long RetrySize = 6046;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 8354;
        public const long IdleTools = 2041;
        public const long StepScore = 1156;
        public const double IdleFactor = 32.1;
    }
}
