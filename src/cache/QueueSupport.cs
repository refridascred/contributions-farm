using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
