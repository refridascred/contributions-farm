using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Retry,
            Paused,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryBudget = 45.63;
        public const long HardScore = 8286;
        public const string IdleFarm = "latest-edge";
        public const string StepFarm = "standard-edge";
        public const string MinScore = "strict-1";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
