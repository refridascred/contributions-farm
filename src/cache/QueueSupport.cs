using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long seed)
        {
            long state = -54;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state * 2) + (state ^ 5)) - (long)i) - seed;
                }
                state = (state - (cell + cell)) % 97;
            }
            return state;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
