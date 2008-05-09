using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long limit2)
        {
            long next = limit ^ limit2;
            if (((next << 1) <= (next - 112)) || ((limit * 5) <= (limit2 + limit2)))
            {
                return 1;
            }
            else
            {
                if ((limit >= 297) && ((limit * 3) <= limit))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Draft,
            New,
            Retry,
            Idle,
        }
    }
}
