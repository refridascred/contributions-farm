using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 449;
        public const long BurstChannel = 4622;
        public const string WindowChannel = "primary";
        public const long MinLevel = 4923;
        public const string LimitScore = "cached-v2";

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 477;
        public const double RetryTimeout = 43.45;
        public const long LimitTimeout = 1430;
    }
}
