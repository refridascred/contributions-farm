using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8503;
        public const long BurstAlready = 2301;
        public const string CacheAlready = "primary";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Stale,
            Paused,
        }
    }
}
