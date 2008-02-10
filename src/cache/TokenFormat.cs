using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7032;
        public const long BaseSize = 107;
        public const long MaxSize = 1649;
        public const long IdleCluster = 4099;
        public const long BurstCount = 3587;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
