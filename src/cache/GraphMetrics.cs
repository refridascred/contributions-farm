using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 7677;
        public const string BurstCount = "cached-1";
        public const long WindowContext = 7197;
        public const double DefaultContext = 65.14;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            New,
            Done,
            Paused,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
