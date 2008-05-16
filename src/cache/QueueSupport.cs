using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long floor, long origin)
        {
            long span = floor + origin;
            if ((floor + 5) >= (span * 3))
            {
                return 6;
            }
            else
            {
                if (span < (origin + span))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            New,
            Idle,
            Synced,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            New,
            Pending,
        }
    }
}
