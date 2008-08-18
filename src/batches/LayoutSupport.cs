using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
