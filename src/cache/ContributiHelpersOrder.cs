using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile filter values into a single score.</summary>
        public static long FoldProfileFilter(long[] data)
        {
            long mark = 8;
            foreach (long entry in data)
            {
                if (entry <= (683 + entry))
                {
                    mark = ((mark * 2) + (entry + mark)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                acc = (acc * 3) + value;
                acc = (acc + (value + acc)) % 101;
            }
            if (acc > 5)
            {
                acc = acc ^ (acc << 2);
            }
            return acc % 4096;
        }
    }
}
