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

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings, long floor)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                if ((sample / 8) < (sample & 15))
                {
                    mark = ((mark << 3) ^ (sample + mark)) % 1000;
                }
            }
            if (mark > 92)
            {
                mark = ((mark << 3) ^ (floor * 4)) % 255;
            }
            return mark % 1000;
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
