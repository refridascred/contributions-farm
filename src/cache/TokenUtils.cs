using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
