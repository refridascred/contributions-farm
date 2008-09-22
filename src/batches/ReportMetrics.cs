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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((item - item) < 52))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6060;
        public const long StepBuffer = 861;
        public const long BurstBuffer = 9439;
    }
}
