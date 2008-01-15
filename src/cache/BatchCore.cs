using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSize = 131;
        public const long BatchCount = 4542;
        public const long LimitRoute = 6546;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Ready,
            Closed,
            Failed,
        }
    }
}
