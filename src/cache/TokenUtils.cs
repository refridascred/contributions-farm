using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepSpan = 9649;
        public const long BurstBatch = 5673;
        public const string SoftBatch = "strict-edge";
        public const long DefaultBatch = 9955;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9305;
        public const long BatchWidth = 2186;
        public const string CacheScore = "cached";

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Active,
            Closed,
        }
    }
}
