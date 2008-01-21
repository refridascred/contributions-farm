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

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFactor = 3289;
        public const long SoftFormat = 6821;
        public const string CacheFormat = "standard-1";
        public const string MaxFormat = "latest-edge";

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
