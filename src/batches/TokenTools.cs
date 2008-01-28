using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 770;
        public const double MaxAccount = 55.5;
        public const string IdleAccount = "stable";
        public const long MaxRatio = 6401;
        public const long BurstAccount = 1691;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
