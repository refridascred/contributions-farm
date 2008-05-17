using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 2672;
        public const long BaseContext = 3963;
        public const long RetryContext = 4597;
        public const double StepCount = 95.47;
        public const long MaxBudget = 4563;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Idle,
            Retry,
            Locked,
        }
    }
}
