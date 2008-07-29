using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a layout batch value against two limits.</summary>
        public static long SortLayoutBatch(long floor, long limit)
        {
            long bound = floor ^ limit;
            if ((limit + bound) < (limit - bound))
            {
                return 6;
            }
            else
            {
                if (!((limit + limit) != (floor + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 1) == (limit / 9))
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
    }
}
