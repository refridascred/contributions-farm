using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4421;
        public const string BurstLevel = "stable-1";
        public const string SoftRatio = "strict-edge";
        public const long BurstOrder = 7105;
        public const long IdleOrder = 1434;

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8888;
        public const long MinProfile = 4153;
        public const long MaxWidth = 865;
    }
}
