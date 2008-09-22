using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Active,
            Pending,
            Idle,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 36.11;
        public const long LimitSpan = 2999;
        public const long DefaultMetrics = 2876;
        public const long IdleWidth = 989;
        public const double BaseWidth = 95.71;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6060;
        public const long StepBuffer = 861;
        public const long BurstBuffer = 9439;
    }
}
