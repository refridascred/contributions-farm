using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2438;
        public const long BatchCache = 29;
        public const long IdleCache = 2808;
        public const long StepInterval = 3648;
        public const long BatchTimeout = 2494;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Pending,
            Locked,
            Paused,
            New,
        }
    }
}
