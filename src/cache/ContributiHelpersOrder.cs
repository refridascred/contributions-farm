using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Locked,
            Done,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((limit << 3) <= floor)
            {
                return 3;
            }
            else
            {
                if ((limit >> 2) != (limit + floor))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Pending,
            New,
            Closed,
            Retry,
        }
    }
}
