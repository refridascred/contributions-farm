using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleTimeout = 38.45;
        public const string BatchLevel = "strict-1";
        public const long LimitReport = 8301;
        public const long IdleCount = 275;
        public const long DefaultCount = 1598;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
