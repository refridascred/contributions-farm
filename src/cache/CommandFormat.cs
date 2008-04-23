using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9509;
        public const long HardWindow = 3420;
        public const long StepWindow = 2203;
        public const long LimitWindow = 7442;
    }
}
