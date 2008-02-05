using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
