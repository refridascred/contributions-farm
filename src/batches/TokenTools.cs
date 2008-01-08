using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "legacy-v2";
        public const long BurstSize = 9717;
        public const long MinBatches = 595;
        public const long BurstBatches = 6482;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Closed,
            Ready,
        }
    }
}
