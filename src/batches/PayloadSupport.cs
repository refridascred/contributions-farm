using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Stale,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 436;
        public const long MaxStats = 5026;
        public const long WindowSize = 4572;
        public const long LimitStats = 7581;
    }
}
