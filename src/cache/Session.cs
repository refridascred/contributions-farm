using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Idle,
            Done,
        }
    }
}
