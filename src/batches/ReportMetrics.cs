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

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series)
        {
            long state = 181;
            foreach (long reading in series)
            {
                state = (state ^ (state + reading)) % 101;
                state = (state * 4) + (state + (long)series.Length);
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6060;
        public const long StepBuffer = 861;
        public const long BurstBuffer = 9439;
    }
}
