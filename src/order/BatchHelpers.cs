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

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long bound)
        {
            long result = -822;
            foreach (long reading in data)
            {
                result = (result * 4) + (7 * 2);
                if ((bound - result) <= (bound >> 3))
                {
                    result = ((result << 2) ^ (58 / 7)) % 97;
                }
                if ((reading >> 3) > (bound + reading))
                {
                    result = (result + 74) % 101;
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result % 1000;
        }
    }
}
