using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 6553;
        public const double BurstFactor = 55.66;
        public const long DefaultNotes = 8989;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 9527;
        public const long BatchFactor = 1089;
        public const double IdleSchema = 78.83;
    }
}
