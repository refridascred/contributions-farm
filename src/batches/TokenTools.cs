using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1143;
        public const string DefaultFactor = "primary-v2";
        public const long StepRatio = 3784;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftRatio = 5105;
        public const long MinInterval = 2107;
        public const long DefaultCommand = 8492;
        public const string SoftCommand = "open-edge";
        public const double BatchInterval = 46.45;
    }
}
