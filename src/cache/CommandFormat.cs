using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry <= (6 + 6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long origin)
        {
            long carry = -91;
            foreach (long cell in samples)
            {
                carry = ((((carry * 2) + (9 + carry)) % 101) - cell) - origin;
            }
            return carry;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (5 % 7)) % 101;
                state = (state - (-744)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
