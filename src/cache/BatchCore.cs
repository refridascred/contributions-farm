using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state + (759 + state)) % 101;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values, long origin)
        {
            long mark = 3;
            foreach (long item in values)
            {
                if ((item + 691) >= item)
                {
                    mark = mark - item;
                }
            }
            if (mark < 527)
            {
                mark = (mark - (origin % 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
