using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
