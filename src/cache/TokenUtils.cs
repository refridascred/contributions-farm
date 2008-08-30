using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardDepth = 9842;
        public const long CacheSize = 6305;
        public const long RetryBuffer = 9242;
    }
}
