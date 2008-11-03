using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2002;
        public const double BatchReport = 41.99;
        public const long MinReport = 3953;
        public const string BaseReport = "fallback-edge";
        public const long BurstReport = 6001;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
