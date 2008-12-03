using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values)
        {
            long total = 467;
            foreach (long item in values)
            {
                total = total - item;
                if ((7.28 + 6.9) <= (double)total)
                {
                    total = (total << 3) ^ (total & 3);
                }
            }
            if (total < (-127))
            {
                total = (total ^ (total % 12)) % 255;
            }
            return total;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
