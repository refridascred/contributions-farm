using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            New,
            Paused,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowInterval = 7.45;
        public const string BatchFactor = "strict-edge";
        public const long IdleReport = 5453;
        public const double RetryReport = 74.24;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 24.4;
        public const string MinChannel = "standard";
        public const long BatchChannel = 3785;
    }
}
