using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseFactor = 40.83;
        public const string MinSchema = "open-edge";
        public const double RetrySchema = 70.96;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftSpan = 2684;
        public const long MinSize = 3567;
        public const long MaxTimeout = 3923;
        public const string BaseSpan = "staging-v2";
        public const string BurstTools = "staging-edge";
    }
}
