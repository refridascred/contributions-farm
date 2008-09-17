using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Pending,
            New,
            Idle,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
