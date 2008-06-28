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

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9529;
        public const long LimitDepth = 4538;
        public const string BurstRecord = "cached-1";
        public const string BurstCount = "alpha";
        public const string DefaultRecord = "staging-1";

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
