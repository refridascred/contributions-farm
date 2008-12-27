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

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Failed,
            Stale,
            Idle,
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
