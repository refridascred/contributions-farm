using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 12.08;
        public const double IdleScore = 2.82;
        public const long BaseEntry = 5175;
        public const long StepEntry = 7947;

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "fallback-v2";
        public const long CacheSize = 4977;
        public const long IdleChannel = 4014;
        public const long LimitChannel = 463;
        public const string BurstFactor = "staging-edge";

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
