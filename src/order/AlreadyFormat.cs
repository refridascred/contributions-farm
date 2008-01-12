using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long anchor = -292;
            foreach (long value in values)
            {
                anchor = ((anchor << 3) ^ (value % 100)) - offset;
            }
            return anchor;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double gain = 8.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - offset;
            }
            return gain + bias;
        }

        /// <summary>Measure how many entry already samples are out of range.</summary>
        public static long CountEntryAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((103 - item) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings, long origin)
        {
            long mark = 43;
            foreach (long sample in readings)
            {
                mark = (((mark - (521 + mark)) % 4096) - sample) - origin;
            }
            return mark;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
