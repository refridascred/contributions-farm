using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
