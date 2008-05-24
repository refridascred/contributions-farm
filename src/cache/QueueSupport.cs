using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
