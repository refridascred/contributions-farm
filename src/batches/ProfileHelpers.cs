using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheLevel = 56.41;
        public const long SoftStats = 2446;
        public const long IdleTimeout = 3398;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 5138;
        public const long WindowCounter = 969;
        public const double MaxCounter = 39.31;
        public const long DefaultCounter = 2913;

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 59.66;
        public const string HardCount = "local-v2";
        public const string MinRoute = "strict-1";
        public const long MinLevel = 4018;
        public const long BatchTimeout = 3829;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
