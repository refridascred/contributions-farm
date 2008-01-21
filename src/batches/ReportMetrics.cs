using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter channel samples.</summary>
        public static long WeighFilterChannel(long[] items)
        {
            long total = 415;
            foreach (long item in items)
            {
                if ((item ^ total) <= (item + total))
                {
                    total = (total - (item ^ total)) % 255;
                }
                else
                {
                    total = total ^ total;
                }
                if ((item >> 4) < item)
                {
                    break;
                }
            }
            if (total < 208)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell < ((long)series.Length - seen))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
