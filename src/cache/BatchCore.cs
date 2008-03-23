using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double gain = floor;
            return gain + ratio;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepLevel = 9979;
        public const double HardRatio = 42.39;
        public const long SoftDepth = 8037;

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "open-1";
        public const double BatchInterval = 23.8;
        public const long RetrySize = 3161;
        public const long BurstSize = 9971;
        public const long RetrySession = 4809;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
