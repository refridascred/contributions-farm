using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultFactor = 88.64;
        public const string HardTimeout = "latest-edge";
        public const double IdleBudget = 90.94;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
