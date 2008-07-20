using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Locked,
            Queued,
            Dropped,
        }
    }
}
