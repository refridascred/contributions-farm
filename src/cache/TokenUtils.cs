using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSize = 1308;
        public const double HardCache = 57.93;
        public const double DefaultCache = 33.48;
        public const long WindowDepth = 4019;
        public const string BaseCache = "cached-edge";

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
