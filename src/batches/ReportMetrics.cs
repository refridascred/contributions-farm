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

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 7085;
        public const double WindowLevel = 28.84;
        public const long SoftInterval = 3174;

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
