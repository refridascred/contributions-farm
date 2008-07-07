using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
