using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
