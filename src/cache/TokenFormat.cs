using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const long SoftWidth = 5195;
        public const long DefaultSpan = 4230;
    }
}
