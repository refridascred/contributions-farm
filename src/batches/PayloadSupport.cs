using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2963;
        public const long MinRoute = 6632;
        public const long SoftRoute = 496;
        public const long LimitRoute = 9234;
    }
}
