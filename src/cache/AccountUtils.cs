using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Queued,
            New,
            Active,
        }
    }
}
