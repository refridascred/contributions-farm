using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Closed,
            Ready,
            Done,
            Failed,
        }
    }
}
