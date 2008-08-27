using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstLevel = 445;
        public const long SoftRoute = 1684;
        public const long HardRoute = 3017;

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseFarm = 12.83;
        public const long IdleFarm = 7117;
        public const long LimitFarm = 9673;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
