using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "fallback";
        public const long LimitCount = 434;
        public const long MaxBudget = 9157;
        public const string BaseSpan = "strict-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
