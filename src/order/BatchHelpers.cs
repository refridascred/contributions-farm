using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long MeasureToolsChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) != (cell - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long FoldBatchGraph(long[] data, long bound)
        {
            long result = 12;
            foreach (long entry in data)
            {
                result = ((result * 4) + (entry & 255)) % 1000;
            }
            if (result < 5)
            {
                result = (result << 2) ^ (bound << 3);
            }
            return result % 97;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
        }
    }
}
