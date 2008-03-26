using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Locked,
            Idle,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Idle,
            Ready,
            Synced,
            Draft,
        }
    }
}
