using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
