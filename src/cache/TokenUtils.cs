using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 49.51;
        public const double MaxSpan = 51.06;
        public const long CacheWidth = 9243;
        public const long IdleSpan = 9668;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 3775;
        public const string SoftMetric = "open-v2";
        public const long DefaultMetric = 1718;
        public const long SoftInterval = 9286;
        public const long StepMetric = 6113;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
