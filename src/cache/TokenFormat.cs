using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Idle,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
