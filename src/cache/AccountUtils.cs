using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "strict";
        public const long LimitRatio = 8161;
        public const long BaseDepth = 8157;
        public const string DefaultTools = "fallback-1";
        public const long WindowTools = 529;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1562;
        public const long HardCounter = 8863;
        public const long MinScore = 8894;
        public const long MinCounter = 389;
    }
}
