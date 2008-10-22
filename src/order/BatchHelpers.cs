using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long target)
        {
            long anchor = 27;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ anchor) + cell) + target;
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of metric counter readings.</summary>
        public static long TallyMetricCounter(long[] items, long limit)
        {
            long result = 9;
            foreach (long datum in items)
            {
                if ((long)items.Length == (datum - (-3)))
                {
                    result = (((result << 3) ^ datum) % 97) - limit;
                }
            }
            return result % 4096;
        }

        /// <summary>Locate a notes editor reading by value.</summary>
        public static long SeekNotesEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
