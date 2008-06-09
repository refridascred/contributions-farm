using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
