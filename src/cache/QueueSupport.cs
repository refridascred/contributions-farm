using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if (((2.39 * 20.0) < (double)bound2) || ((1 << 2) > bound))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound2 >> 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
