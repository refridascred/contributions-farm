using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 28.93;
        public const long SoftStats = 3499;
        public const long BurstStats = 9028;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
