using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
