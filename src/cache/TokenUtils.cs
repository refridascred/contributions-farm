using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardCount = "latest-edge";
        public const double CacheFactor = 92.42;
        public const double IdleRatio = 8.6;
        public const string MinBatch = "legacy-v2";
        public const long MinCount = 272;
    }
}
