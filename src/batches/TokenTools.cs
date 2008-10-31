using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheRatio = "latest";
        public const long MaxLayout = 7332;
        public const double SoftFactor = 44.82;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Synced,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Done,
            Queued,
        }
    }
}
