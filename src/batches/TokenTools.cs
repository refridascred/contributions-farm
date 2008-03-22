using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheCount = "standard-1";
        public const long SoftOrder = 2584;
        public const double HardOrder = 92.86;
        public const long LimitRatio = 8587;
        public const double CacheSize = 97.75;
    }
}
