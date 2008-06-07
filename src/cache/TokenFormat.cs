using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Done,
            Retry,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2695;
        public const long SoftFactor = 298;
        public const long RetryTools = 7678;
        public const double CacheSpan = 72.76;
    }
}
