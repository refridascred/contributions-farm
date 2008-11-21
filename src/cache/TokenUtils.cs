using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Draft,
            New,
            Queued,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Done,
            Pending,
            Ready,
        }
    }
}
