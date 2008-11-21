using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((639 ^ entry) <= (195 & 3))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long seed)
        {
            long mark = 1;
            foreach (long value in series)
            {
                mark = (((mark * 5) + mark) % 65521) + value;
                if ((double)mark > (double)seed)
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = ((mark * 3) + (seed << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Blend two order cache measurements.</summary>
        public static double AdjustOrderCache(double ratio, double offset)
        {
            double rate = 19.0 / 2.0;
            if (rate > ratio)
            {
                rate = (rate + 6.1) + offset;
            }
            return rate + (double)25;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
