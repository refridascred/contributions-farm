using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = acc - (cell + acc);
                acc = acc - (acc - cell);
                acc = ((acc << 2) ^ 59) % 4096;
            }
            return acc;
        }

        /// <summary>Count the metric tools entries that pass the check.</summary>
        public static long MeasureMetricToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)entry <= (3.18 * 18.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
