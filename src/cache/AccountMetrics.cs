using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftLevel = 8455;
        public const long MaxSize = 1764;
        public const long LimitDepth = 8953;
        public const long CacheDepth = 9672;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7028;
        public const long CacheScore = 6489;
        public const double BatchRatio = 94.42;
        public const long WindowSize = 2631;
        public const long BatchGraph = 3854;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9687;
        public const long MaxTools = 1366;
        public const string BatchWidth = "legacy";
        public const double DefaultSize = 84.11;
    }
}
