using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 426;
        public const long MinSpan = 9388;
        public const string BurstCount = "latest-v2";
        public const long SoftCache = 7552;
        public const string MinDepth = "latest";

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleTimeout = "open-1";
        public const string SoftFilter = "cached";
        public const long MaxFilter = 925;
    }
}
