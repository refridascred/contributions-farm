using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a context already sample.</summary>
        public static long LocateContextAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 7443;
        public const long BatchSize = 4728;
        public const string IdleCommand = "fallback";
    }
}
