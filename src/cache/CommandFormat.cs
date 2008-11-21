using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long acc = -189;
            foreach (long cell in levels)
            {
                acc = ((acc * 2) + (96 >> 1)) % 97;
                acc = acc ^ acc;
                if ((3.4 - 3.0) <= (double)cell)
                {
                    break;
                }
            }
            return acc % 4096;
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= (double)datum)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
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
