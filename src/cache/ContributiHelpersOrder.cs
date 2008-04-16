using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
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
