using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Idle,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long limit)
        {
            long edge = offset + limit;
            if ((offset / 6) <= (limit + offset))
            {
                return 5;
            }
            else
            {
                if ((limit >> 2) >= (edge + edge))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
