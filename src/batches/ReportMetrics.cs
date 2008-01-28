using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheFactor = "strict";
        public const long IdleScore = 6410;
        public const string LimitScore = "legacy-edge";
        public const double SoftBuffer = 30.14;
        public const long BatchBuffer = 9854;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Find the first support tools entry that matches the target.</summary>
        public static long FindSupportToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
