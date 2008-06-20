using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchWidth = 3430;
        public const long LimitInterval = 2569;
        public const string HardInterval = "alpha-v2";
        public const long LimitScore = 6590;
        public const long SoftSpan = 7879;

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 6529;
        public const string BaseCount = "stable";
        public const long DefaultSize = 1745;
        public const double RetryRatio = 96.16;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "open-edge";
        public const double MinFarm = 90.98;
        public const long MaxLevel = 2006;
        public const double MinBudget = 49.2;
    }
}
