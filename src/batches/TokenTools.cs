using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 4421;
        public const string HardSize = "strict";
        public const double WindowTimeout = 7.02;
        public const long LimitSize = 6034;
    }
}
