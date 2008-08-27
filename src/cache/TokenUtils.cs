using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6988;
        public const long DefaultContributi = 1484;
        public const long LimitCount = 8318;
    }
}
