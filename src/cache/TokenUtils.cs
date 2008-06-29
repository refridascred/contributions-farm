using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Queued,
            Dropped,
            New,
            Stale,
        }
    }
}
