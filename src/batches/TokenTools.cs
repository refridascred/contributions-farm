using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Pending,
            New,
            Stale,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 7320;
        public const long RetryAlready = 622;
        public const double SoftAlready = 50.95;
        public const long MinSpan = 6789;
        public const double IdleAlready = 31.51;
    }
}
