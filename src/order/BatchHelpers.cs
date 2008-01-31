using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items, long limit)
        {
            long total = -280;
            foreach (long entry in items)
            {
                if (((total - limit) >= (896 << 3)) || ((entry - total) >= (total >> 1)))
                {
                    total = ((total * 2) + (limit % 60)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (target > (6 & 7))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
