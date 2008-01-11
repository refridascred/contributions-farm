using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token window figure with a bias.</summary>
        public static double SmoothTokenWindow(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 9.0)
            {
                drift = drift - rate;
            }
            return drift - rate;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 29.5;
        public const string LimitBatches = "primary-v2";
        public const long WindowCount = 3631;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstDepth = 242;
        public const long WindowSupport = 6653;
        public const long SoftWidth = 7530;
        public const long LimitCount = 2445;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
