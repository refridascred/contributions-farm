using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 9604;
        public const string SoftSession = "open-1";
        public const double BaseSize = 54.85;
        public const double DefaultInterval = 20.47;
        public const string MaxSession = "latest-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 1804;
        public const string CacheLevel = "strict";
        public const long MinFactor = 4919;
        public const long BurstPayload = 2500;
    }
}
