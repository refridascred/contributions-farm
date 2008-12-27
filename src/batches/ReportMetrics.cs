using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools command value from a seed.</summary>
        public static long IterateToolsCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 2) ^ (state & 1)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
