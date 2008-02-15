using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Done,
            Paused,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
