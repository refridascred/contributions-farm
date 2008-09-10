using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 42.21;
        public const long StepMetrics = 8363;
        public const long IdleRatio = 7460;
        public const long HardMetrics = 8462;
        public const long MaxWidth = 6272;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Idle,
            Draft,
        }
    }
}
