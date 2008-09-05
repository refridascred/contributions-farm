using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9880;
        public const double MaxSpan = 67.07;
        public const long BaseNotes = 7732;
        public const long MaxNotes = 7503;
        public const double MaxSize = 41.17;

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 96.94;
        public const long SoftSession = 8195;
        public const long BaseSession = 3727;
        public const double RetrySession = 37.01;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
