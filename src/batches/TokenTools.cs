using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 5082;
        public const string BaseWindow = "staging";
        public const string SoftWindow = "fallback-v2";
        public const string DefaultRatio = "primary-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 27.57;
        public const long WindowCluster = 1083;
        public const long BatchCluster = 7043;
    }
}
