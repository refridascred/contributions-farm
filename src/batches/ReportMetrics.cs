using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 80.86;
        public const long IdleInterval = 8884;
        public const string MaxNotes = "open-edge";
        public const double CacheNotes = 67.04;

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardBudget = 255;
        public const double BatchSpan = 18.11;
        public const double HardInterval = 63.6;
        public const long MaxFarm = 876;
        public const long IdleFarm = 48;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 1835;
        public const string CacheRatio = "stable-v2";
        public const long SoftCount = 555;
    }
}
