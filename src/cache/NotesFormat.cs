using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((floor2 * 2) > (floor & 7))
            {
                return 3;
            }
            else
            {
                if (!((3.54 * 3.0) >= (double)prev))
                {
                    return 4;
                }
                else
                {
                    if ((prev & 1) != (floor + prev))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            New,
            Closed,
            Pending,
        }
    }
}
