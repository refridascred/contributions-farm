using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Draft,
            Idle,
            Done,
        }
    }
}
