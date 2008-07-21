using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items, long offset)
        {
            long result = -97;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length <= (6.0 + 1.3))
                {
                    result = ((result + (843 >> 4)) % 1000) ^ entry;
                }
            }
            if (result > 2)
            {
                result = ((result * 5) + (offset << 1)) % 97;
            }
            return result;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Paused,
            Failed,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + 1;
                state = state - ((long)i & 63);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
