using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + matches) <= 14)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 8922;
        public const double HardPayload = 25.45;
        public const double BatchPayload = 64.44;
        public const long HardTimeout = 1700;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Idle,
            Failed,
            Closed,
        }
    }
}
